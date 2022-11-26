Program.Main();
class Program {
  // 2点間の距離を求める
  static double CalcDist(double x1, double y1, double x2, double y2) {
    return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)); 
  }
  
  // 解く
  static void Solve() {
    var n = int.Parse(Console.ReadLine());
    (double[] x, double[] y) = (new double[n], new double[n]);
    for(int i=0; i<n; i++) {
      string line = Console.ReadLine();
      string[] array = line.Split(' ');
      (x[i], y[i]) = (int.Parse(array[0]), int.Parse(array[1]));
      Console.WriteLine($"x[{i}]: {x[i]}, y[{i}]: {y[i]}");
    }

    double minimumDist = 100000000.0;
    
    // 探索開始
    for(int i=0; i<n; i++) {
      for(int j=i+1; j<n; j++) {
        double distij = CalcDist(x[i], y[i], x[j], y[j]);

        if(distij < minimumDist) {
          minimumDist = distij;
        }
      }
    }

    Console.WriteLine($"minimumDist: {minimumDist}");
  }

  public static void Main() {
    Console.Write("number: ");
    Solve();
  }
}

class Program {
  public static void Main() {
     Solve();
  }

  static void Solve() {
    string line = Console.ReadLine();
    string[] array = line.Split(' ');
    (var N, var v) = (int.Parse(array[0]), int.Parse(array[1]));
    int[] a = new int[N];
    for(int i=0; i<N; i++) a[i] = int.Parse(Console.ReadLine());

    bool exist = false;
    for(int i=0; i<N; i++) {
      if(a[i] == v) {
        exist = true;
        break;
      }
    }

    Console.WriteLine($"{(exist==true ? "Yes" : "No")}");
   }
}
Program.Main();

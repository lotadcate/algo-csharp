void Solve() {
  Console.WriteLine("Start ...");
  string line = Console.ReadLine();
  string[] array = line.Split(' ');
  (var n, var w) = (int.Parse(array[0]), int.Parse(array[1]));
  int[] a = new int[n];
  for(int i=0; i<n; i++) a[i] = int.Parse(Console.ReadLine());

  bool exist = false;
  for(int bit=0; bit<(1<<n); bit++) {
    int sum = 0;
    Console.WriteLine("------------------");
    for(int i=0; i<n; i++) {
      Func<int, int, bool> Judge = (x, y) => ((x & y) != 0) ? true : false;
      bool flag = Judge(bit, (1<<i));
      if(flag) {
        sum += a[i];
        Console.WriteLine($"sum: {sum}, a[{i}]: {a[i]}");
      }
    }
    if(sum==w) {
      exist = true;
      break;
    }
  }
  Console.WriteLine($"{(exist==true ? "Yes" : "No")}");
}
Solve();

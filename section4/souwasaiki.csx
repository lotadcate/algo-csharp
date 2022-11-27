int Func(int n) {
  if (n==0) return 0;
  return n+Func(n-1);
}

Console.Write("number : ");
var n = int.Parse(Console.ReadLine());
var ans = Func(n);
Console.WriteLine($"ans:{ans}");

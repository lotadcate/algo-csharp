void Solve() {
  Console.Write("number : ");
  var n = int.Parse(Console.ReadLine());
  int[] h = new int[n];
  Console.Write("building : ");
  for(int i=0; i<n; i++) h[i] = int.Parse(Console.ReadLine());

  int[] dp = new int[n];
  for(int i=0; i<n; i++) dp[i] = 1000000000;
  dp[0] = 0;

  for(int i=1; i<n; i++) {
    if(i==1) dp[i] = Math.Abs(h[i] - h[i-1]);
    else dp[i] = Math.Min(dp[i-1]+Math.Abs(h[i]-h[i-1]), dp[i-2]+Math.Abs(h[i]-h[i-2]));
  }

  Console.WriteLine($"dp[n-1] = {dp[n-1]}");
}

Solve();

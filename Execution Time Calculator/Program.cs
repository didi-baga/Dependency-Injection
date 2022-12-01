using System.Diagnostics;

for (int i = 0; i < args.Length; i++)
{
    var watch = new System.Diagnostics.Stopwatch();
    watch.Start();
    
    Process.Start("CMD.exe", args[i]);

    watch.Stop();
    Console.WriteLine($"\n\n\n Arg[{i}] = [{args[i]}] Execution Time: {watch.ElapsedMilliseconds} ms \n\n\n\n\n\n");
}
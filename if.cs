// Window: csc /nostdlib /noconfig /r:packages\System.Runtime.4.0.20-beta-22703\lib\contract\System.Runtime.dll /r:packages\System.Console.4.0.0-beta-22703\lib\contract\System.Console.dll /out:runtime\HelloWorld.exe HelloWorld.cs
// Linux: csc //nostdlib //noconfig //r:packages\\System.Runtime.4.0.20-beta-22703\\lib\\contract\\System.Runtime.dll //r:packages\\System.Console.4.0.0-beta-22703\\lib\\contract\\System.Console.dll //out:if.exe if.cs
using System;

public class Program
{
    public static void Main (string[] args)
    {
		string sel = args[0];
		int suffix = 0;
	    if (sel == "1") {
			suffix = 1;
		}
        Console.WriteLine(suffix);
    }
} 
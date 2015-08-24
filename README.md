# AutoItCSharpWrapper

AutoItCHarpWrapper's goal is to increase universal functionality and easy of use in C# while using AutoItX3Lib. 

// example:
static void Main( string[] args )
{
    if ( !WinExist( "Untitled - Notepad" ) )
    {
        RunWait( "notepad.exe", "C:\\Windows\\system32\\" );
    }
     WinActivate();
    WinWaitActive();
    WinSetOnTop();
    WinClose();

    Console.WriteLine( "Last Window: {0}", LastWindow );
    Console.ReadLine();
}
// end example


With traditional use of AutoItX3 we need to pass arguements every time we call a method.
However, we are able to act upon the target window until another window Title / HWND is explicity passed to a method.

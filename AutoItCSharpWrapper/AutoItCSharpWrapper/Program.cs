using System;
using System.Threading;
using AutoItX3Lib;

namespace AutoItCSharpWrapper
{
    public class Au3
    {
        public static AutoItX3Lib.AutoItX3 au3;

        /// <summary>
        ///     Store the last window handle
        /// </summary>
        public static string LastWindow { get; set; }

        static Au3()
        {
            au3 = new AutoItX3Lib.AutoItX3();
            LastWindow = "";
        }

        #region WindowTools

        private static void LastWindowCheck( string win )
        {
            LastWindow = win != LastWindow ? LastWindow = win : LastWindow = LastWindow;
        }

        public static bool WinExist( string win )
        {
            LastWindowCheck( win );
            return au3.WinExists( win, "" ) != 0;
        }

        public static bool WinExist( string win, out string lastWindow )
        {
            lastWindow = win != LastWindow ? LastWindow = win : LastWindow;
            return au3.WinExists( win, "" ) != 0;
        }

        public static bool WinExist( string win, string txt )
        {
            LastWindowCheck( win );
            return au3.WinExists( win, txt ) != 0;
        }

        public static bool WinExist( string win, string txt, out string lastWindow )
        {
            lastWindow = win != LastWindow ? LastWindow = win : LastWindow = LastWindow;
            return au3.WinExists( win, txt ) != 0;
        }

        public static bool WinActive( string win )
        {
            LastWindowCheck( win );
            return au3.WinActive( win, "" ) != 0;
        }

        public static bool WinActive( string win, string txt )
        {
            LastWindowCheck( win );
            return au3.WinActive( win, txt ) != 0;
        }

        public static bool WinActive( string win, out string lastWindow )
        {
            lastWindow = win != LastWindow ? LastWindow = win : LastWindow = LastWindow;
            return au3.WinActive( win, "" ) != 0;
        }

        public static void WinActivate()
        {
            au3.WinActivate( LastWindow, "" );
        }

        public static void WinActivate( string win )
        {
            LastWindowCheck( win );
            au3.WinActivate( win, "" );
        }

        public static void WinActivate( string win, string txt )
        {
            LastWindowCheck( win );
            au3.WinActivate( win, txt );
        }

        public static bool WinWaitNotActive()
        {
            return au3.WinWaitNotActive( LastWindow, "", 100 ) != 0;
        }

        public static bool WinWaitNotActive( string win )
        {
            LastWindowCheck( win );
            return au3.WinWaitNotActive( win, "", 100 ) != 0;
        }

        public static bool WinWaitNotActive( string win, int timeout )
        {
            LastWindowCheck( win );
            return au3.WinWaitNotActive( win, "", timeout ) != 0;
        }

        public static bool WinWaitNotActive( string win, string txt, int timeout )
        {
            LastWindowCheck( win );
            return au3.WinWaitNotActive( win, txt, timeout ) != 0;
        }

        public static bool WinWaitActive()
        {
            return au3.WinWaitActive( LastWindow, "", 100 ) != 0;
        }

        public static bool WinWaitActive( string win )
        {
            LastWindowCheck( win );
            return au3.WinWaitActive( win, "", 100 ) != 0;
        }

        public static bool WinWaitActive( string win, string txt )
        {
            LastWindowCheck( win );
            return au3.WinWaitActive( win, txt, 100 ) != 0;
        }

        public static bool WinWaitActive( string win, string txt, int timeout )
        {
            LastWindowCheck( win );
            return au3.WinWaitActive( win, txt, timeout ) != 0;
        }

        public static void WinClose()
        {
            au3.WinClose( LastWindow, "" );
        }

        public static void WinClose( string win )
        {
            LastWindowCheck( win );
            au3.WinClose( win, "" );
        }

        public static void WinClose( string win, string txt )
        {
            LastWindowCheck( win );
            au3.WinClose( win, txt );
        }


        public static string WinGetClassList()
        {
            return au3.WinGetClassList( LastWindow, "" );
        }

        public static string WinGetClassList( string win )
        {
            LastWindowCheck( win );
            return au3.WinGetClassList( win, "" );
        }

        public static string WinGetClassList( string win, string txt )
        {
            LastWindowCheck( win );
            return au3.WinGetClassList( win, txt );
        }

        public static string WinGetHandle()
        {
            return au3.WinGetHandle( LastWindow, "" );
        }

        public static string WinGethandle( string win )
        {
            LastWindowCheck( win );
            return au3.WinGetHandle( win, "" );
        }

        public static string WinGethandle( string win, string txt )
        {
            LastWindowCheck( win );
            return au3.WinGetHandle( win, txt );
        }

        public static string WinGetProcess()
        {
            return au3.WinGetProcess( LastWindow, "" );
        }

        public static string WinGetProcess( string win )
        {
            LastWindowCheck( win );
            return au3.WinGetProcess( win, "" );
        }

        public static string WinGetProcess( string win, string txt )
        {
            LastWindowCheck( win );
            return au3.WinGetProcess( win, txt );
        }

        public static int WinGetPosX()
        {
            return au3.WinGetPosX( LastWindow, "" );
        }

        public static int WinGetPosX( string win )
        {
            LastWindowCheck( win );
            return au3.WinGetPosX( win, "" );
        }

        public static int WinGetPosX( string win, string txt )
        {
            LastWindowCheck( win );
            return au3.WinGetPosX( win, txt );
        }

        public static int WinGetPosY()
        {
            return au3.WinGetPosY( LastWindow, "" );
        }

        public static int WinGetPosY( string win )
        {
            LastWindowCheck( win );
            return au3.WinGetPosX( win, "" );
        }

        public static int WinGetPosY( string win, string txt )
        {
            LastWindowCheck( win );
            return au3.WinGetPosY( win, txt );
        }

        public static int WinGetPosHeight()
        {
            return au3.WinGetPosHeight( LastWindow, "" );
        }

        public static int WinGetPosHeight( string win )
        {
            LastWindowCheck( win );
            return au3.WinGetPosX( win, "" );
        }

        public static int WinGetPosHeight( string win, string txt )
        {
            LastWindowCheck( win );
            return au3.WinGetPosHeight( win, txt );
        }

        public static int WinGetPosWidth()
        {
            return au3.WinGetPosWidth( LastWindow, "" );
        }

        public static int WinGetPosWidth( string win )
        {
            LastWindowCheck( win );
            return au3.WinGetPosX( win, "" );
        }

        public static int WinGetPosWidth( string win, string txt )
        {
            LastWindowCheck( win );
            return au3.WinGetPosWidth( win, txt );
        }

        public static int WinGetClientSizeHeight()
        {
            return au3.WinGetClientSizeHeight( LastWindow, "" );
        }

        public static int WinGetClientSizeHeight( string win )
        {
            LastWindowCheck( win );
            return au3.WinGetPosX( win, "" );
        }

        public static int WinGetClientSizeHeight( string win, string txt )
        {
            LastWindowCheck( win );
            return au3.WinGetClientSizeHeight( win, txt );
        }

        public static int WinGetClientSizeWidth()
        {
            return au3.WinGetClientSizeWidth( LastWindow, "" );
        }

        public static int WinGetClientSizeWidth( string win )
        {
            LastWindowCheck( win );
            return au3.WinGetPosX( win, "" );
        }

        public static int WinGetClientSizeWidth( string win, string txt )
        {
            LastWindowCheck( win );
            return au3.WinGetClientSizeWidth( win, txt );
        }

        public static string WinGetText()
        {
            return au3.WinGetText( LastWindow, "" );
        }

        public static string WinGetText( string win )
        {
            LastWindowCheck( win );
            return au3.WinGetText( win, "" );
        }

        public static string WinGetText( string win, string txt )
        {
            LastWindowCheck( win );
            return au3.WinGetText( win, txt );
        }

        public static int WinGetState()
        {
            return au3.WinGetState( LastWindow, "" );
        }

        public static int WinGetState( string win )
        {
            LastWindowCheck( win );
            return au3.WinGetPosX( win, "" );
        }

        public static int WinGetState( string win, string txt )
        {
            LastWindowCheck( win );
            return au3.WinGetState( win, txt );
        }

        public static void WinKill()
        {
            au3.WinKill( LastWindow, "" );
        }

        public static void WinKill( string win )
        {
            LastWindowCheck( win );
            au3.WinKill( win, "" );
        }

        public static void WinKill( string win, string txt )
        {
            LastWindowCheck( win );
            au3.WinKill( win, txt );
        }

        public static void WinMove( int x, int y )
        {
            au3.WinMove( LastWindow, "", x, y, -1, -1 );
        }

        public static void WinMove( string win, int x, int y )
        {
            LastWindowCheck( win );
            au3.WinMove( win, "", x, y, -1, -1 );
        }

        public static void WinMove( string win, string txt, int x, int y )
        {
            LastWindowCheck( win );
            au3.WinMove( win, txt, x, y, -1, -1 );
        }

        public static void WinMove( string win, string txt, int x, int y, out bool success )
        {
            LastWindowCheck( win );
            au3.WinMove( win, txt, x, y, -1, -1 );
            success = au3.WinMove( win, txt, x, y, -1, -1 ) != 0;
        }

        public static void WinMove( string win, int x, int y, out bool success )
        {
            LastWindowCheck( win );
            au3.WinMove( win, "", x, y, -1, -1 );
            success = au3.WinMove( win, "", x, y, -1, -1 ) != 0;
        }

        public static void WinMove( int x, int y, out bool success )
        {
            au3.WinMove( LastWindow, "", x, y, -1, -1 );
            success = au3.WinMove( LastWindow, "", x, y, -1, -1 ) != 0;
        }

        public static bool WinSetOnTop()
        {
            return au3.WinSetOnTop( LastWindow, "", 1 ) != 0;
        }

        public static bool WinSetOnTop( string win )
        {
            LastWindowCheck( win );
            return au3.WinSetOnTop( win, "", 1 ) != 0;
        }

        public static bool WinSetOnTop( string win, string txt )
        {
            LastWindowCheck( win );
            return au3.WinSetOnTop( win, txt, 1 ) != 0;
        }

        public static bool WinSetOnTop( string win, int flag )
        {
            LastWindowCheck( win );
            if ( flag != 0 || flag != 1 )
            {
                return false;
            }
            return au3.WinSetOnTop( win, "", flag ) != 0;
        }

        public static bool WinSetOnTop( string win, string txt, int flag )
        {
            LastWindowCheck( win );
            if ( flag != 0 || flag != 1 )
            {
                return false;
            }
            return au3.WinSetOnTop( win, txt, flag ) != 0;
        }
        #endregion

        public static bool Run( string exe, string dir )
        {
            return au3.Run( exe, dir, au3.SW_SHOW ) != 0;
        }

        public static bool RunWait( string exe, string dir )
        {
            return au3.Run( exe, dir, au3.SW_SHOW ) != 0;
        }

        public static void Sleep( int ms )
        {
            Thread.Sleep( ms );
        }
    }

    class Program : Au3
    {
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
    }
}

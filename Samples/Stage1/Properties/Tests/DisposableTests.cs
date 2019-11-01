using System;
using System.IO;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Stage1
{
    public class DisposableTests
    {
        [TestCase("D:\\test.txt")]
        public void ManuallyDisposeTest(string path)
        {
            var fileWrapper = new FileWrapper(path);
            fileWrapper.Dispose();
        }
        
        [TestCase("D:\\test.txt")]
        public void UsingDisposeTest(string path)
        {
            using (var fileWrapper = new FileWrapper(path))
            {
                fileWrapper.Dispose();                
            }
        }
    }
    
    public class FileWrapper : IDisposable
    {
        IntPtr _handle;

        public FileWrapper(string name)
        {
            _handle = CreateFile(lpFileName: name,
                dwDesiredAccess: 0,
                dwShareMode: FileShare.ReadWrite,
                lpSecurityAttributes: IntPtr.Zero,
                dwCreationDisposition: FileMode.OpenOrCreate,
                dwFlagsAndAttributes: 0,
                hTemplateFile: IntPtr.Zero );
        }

        public void Dispose()
        {
            CloseHandle(_handle);
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true, BestFitMapping = false)]
        private static extern IntPtr CreateFile(
            string lpFileName,
            int dwDesiredAccess,
            FileShare dwShareMode,
            IntPtr lpSecurityAttributes,
            FileMode dwCreationDisposition,
            int dwFlagsAndAttributes,
            IntPtr hTemplateFile);
        
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool CloseHandle(IntPtr hObject);
    }
}
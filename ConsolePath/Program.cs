using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }

        #region 取得資料夾下所有檔案、資料夾資訊

        /// <summary>
        /// 取得該路徑底下所有資料夾名稱、檔案名稱路徑
        /// </summary>
        /// <param name="filePath">完整資料夾路徑</param>
        /// <returns></returns>
        public IEnumerable<string> GetEnumerateFileSystemEntries(string filePath)
        {
            return Directory.EnumerateFileSystemEntries(filePath);
        }

        /// <summary>
        /// 取得該路徑底下所有檔案名稱路徑
        /// </summary>
        /// <param name="filePath">完整資料夾路徑</param>
        /// <returns></returns>
        public IEnumerable<string> GetEnumerateFiles(string filePath)
        {
            return Directory.EnumerateFiles(filePath);
        }

        /// <summary>
        /// 取得該路徑底下所有資料夾名稱路徑
        /// </summary>
        /// <param name="filePath">完整資料夾路徑</param>
        /// <returns></returns>
        public IEnumerable<string> GetEnumerateDirectories(string filePath)
        {
            return Directory.EnumerateDirectories(filePath);
        }

        #endregion

        #region 檔案複製、寫入、刪除、搬移、判斷存在

        /// <summary>
        /// 把檔案搬移到別處
        /// </summary>
        /// <param name="fromFilePath">來源完整檔名包含檔名、副檔名</param>
        /// <param name="toFilePath">目標完整檔名包含檔名、副檔名</param>
        public void FileMove(string fromFilePath,string toFilePath)
        {
            File.Move(fromFilePath, toFilePath);
        }

        /// <summary>
        /// 透過完整路徑,刪除檔案
        /// 只可以刪除檔案，不可以刪除資料夾
        /// </summary>
        /// <param name="filePath"></param>
        public void FileDelete(string filePath)
        {
            File.Delete(filePath);
        }

        /// <summary>
        /// 從某處複製檔案到另一個某處
        /// </summary>
        /// <param name="fromFilePath">來源完整檔名包含檔名、副檔名</param>
        /// <param name="toFilePath">目標完整檔名包含檔名、副檔名</param>
        public void CopyFile(string fromFilePath,string toFilePath)
        {
            File.Copy(fromFilePath, toFilePath);
        }

        /// <summary>
        /// 把檔案寫入電腦
        /// </summary>
        /// <param name="path">完整路徑，包含檔名、副檔名txt之類的</param>
        public void WriteToPC(string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                    sw.WriteLine("DataLine");
            }
        }

        /// <summary>
        /// 完整檔案路徑判斷檔案是否存在
        /// </summary>
        /// <param name="filePath">完整檔案路徑，包含檔名、副檔名</param>
        /// <returns></returns>
        public bool FileExists(string filePath)
        {
            return File.Exists(filePath);
        }


        #endregion

        #region 資料夾 搬移、刪除、建立、判斷存在

        /// <summary>
        /// 透過完整路徑，把資料夾移動到另一個地方
        /// </summary>
        /// <param name="fromFilePath">完整來源資料夾路徑</param>
        /// <param name="toFilePath">完整目標資料夾路徑</param>
        public void FolderMove(string fromFilePath, string toFilePath)
        {
            Directory.Move(fromFilePath, toFilePath);
        }

        /// <summary>
        /// 透過完整路徑刪除資料夾
        /// 只能刪除空的資料夾
        /// </summary>
        /// <param name="filePath"></param>
        public void DeleteDirectory(string filePath)
        {
            Directory.Delete(filePath);
        }

        /// <summary>
        /// 透過完整路徑，建立folder
        /// 可一次巢狀建立
        /// </summary>
        /// <param name="fullFilePath">完整路徑(包含要建立的資料夾名稱)</param>
        public void CreateDirectory(string fullFilePath)
        {
            Directory.CreateDirectory(fullFilePath);
        }


        /// <summary>
        /// 傳入完整資料夾路徑、或含檔名的路徑
        /// 判斷該路徑或是檔案是否存在
        /// </summary>
        /// <param name="filePath">完整資料夾路徑、或含檔名的路徑</param>
        /// <returns></returns>
        public bool FileOrFolderExists(string filePath)
        {
            return Directory.Exists(filePath);
        }

        #endregion

        #region 路徑、檔名、副檔名相關處理

        /// <summary>
        /// 路徑合併
        /// </summary>
        /// <param name="filePath1"></param>
        /// <param name="filePath2"></param>
        /// <returns></returns>
        public string PathCombine(string filePath1,string filePath2)
        {
            return Path.Combine(filePath1, filePath2);
        }

        /// <summary>
        /// 判斷是否有附檔名
        /// </summary>
        /// <param name="filePath">完整路徑</param>
        /// <returns></returns>
        public bool HasExtension(string filePath)
        {
            return System.IO.Path.HasExtension(filePath);
        }

        /// <summary>
        /// 回傳最上層實體路徑
        /// </summary>
        /// <param name="fileName">完整路徑(包含檔名、不包含檔名皆可)</param>
        /// <returns></returns>
        public string GetPathRoot(string filePath)
        {
            return System.IO.Path.GetPathRoot(filePath);
        }

        /// <summary>
        /// 取得檔案名稱不包含副檔名
        /// </summary>
        /// <param name="fileName">完整路徑(包含檔案名稱、副檔名)</param>
        /// <returns></returns>
        public string GetFileNameWithoutExtension(string filePath)
        {
            return System.IO.Path.GetFileNameWithoutExtension(filePath);
        }

        /// <summary>
        /// 取得檔名+副檔名
        /// </summary>
        /// <param name="filePath">完整路徑(包含檔案名稱、副檔名)</param>
        /// <returns></returns>
        public string GetFileName(string filePath)
        {
            return System.IO.Path.GetFileName(filePath);
        }

        /// <summary>
        /// 給完整路徑(包含檔案名稱、副檔名)
        /// 回傳.副檔名(前面會包含.)
        /// </summary>
        /// <param name="filePath">完整路徑(包含檔案名稱、副檔名)</param>
        /// <returns></returns>
        public string GetExtension(string filePath)
        {
            return System.IO.Path.GetExtension(filePath);
        }

        /// <summary>
        /// 變更副檔名
        /// </summary>
        /// <param name="filePath">包含檔案名稱的完整路徑</param>
        /// <param name="extension">目標副檔名</param>
        public void ChangeExtension(string filePath, string extension)
        {
            System.IO.Path.ChangeExtension(filePath, "extension");
        }

        /// <summary>
        /// 檔路徑=>路徑
        /// 給完整路徑(包含檔案名稱、副檔名)
        /// 回傳該檔案的資料夾完整路徑
        /// </summary>
        /// <param name="filePath">完整路徑(包含檔案名稱、副檔名)</param>
        /// <returns></returns>
        public string GetDirectoryPath(string filePath)
        {
            return System.IO.Path.GetDirectoryName(filePath);
        }

        #endregion

        #region 取得應用程式當前目錄、所執行應用程式完整路徑

        /// <summary>
        /// 取得應用程式所執行的跟目錄
        /// </summary>
        /// <returns></returns>
        public string GetCurrentPath()
        {
            // 較常用
            // 取得和設置當前目錄（即該進程從中啟動的目錄）的完全限定路徑。
            // 結果: C:\xxx\xxx
            string str = System.Environment.CurrentDirectory;
            Console.WriteLine(str);

            // 取得啟動了應用程序的可執行文件的路徑，不包括可執行文件的名稱。
            // 結果: C:\xxx\xxx
            str = System.Windows.Forms.Application.StartupPath;
            Console.WriteLine(str);

            // 取得應用程序的當前工作目錄。
            // 結果: C:\xxx\xxx
            str = System.IO.Directory.GetCurrentDirectory();
            Console.WriteLine(str);

            return str;
        }

        /// <summary>
        /// 取得當前目錄下所執行的應用程式完整路徑
        /// </summary>
        /// <returns></returns>
        public string GetCurrentExeFullPath()
        {

            // 多取得應用程式
            // 取得當前執行的exe的文件名。
            // 結果: C:\xxx\xxx\xxx.exe
            string str = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            Console.WriteLine(str);

            // 多取得應用程式
            // 取得啟動了應用程序的可執行文件的路徑，包括可執行文件的名稱。
            // 結果: C:\xxx\xxx\xxx.exe
            str = System.Windows.Forms.Application.ExecutablePath;
            Console.WriteLine(str);

            return str;
        }

        /// <summary>
        /// 取得應用程式當前目錄，並多一個\
        /// </summary>
        /// <returns></returns>
        public string GetCurrentPathAndNext()
        {
            // 多一個\
            // 取得當前 Thread 的當前應用程序域的基目錄，它由程序集衝突解決程序用來探測程序集。
            // 結果: C:\xxx\xxx\
            string str = System.AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine(str);

            // 多一個\
            // 取得和設置包含該應用程序的目錄的名稱。
            // 結果: C:\xxx\xxx\
            str = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            Console.WriteLine(str);

            return str;
        }

        #endregion
    }
}

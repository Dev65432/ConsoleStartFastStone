using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStartFastStone
{
    static class FastStoneService
    {
        static string PathToFastStoneExe = @"c:\ProgramFilesPortable\FastStone_Image_Viewer_7.8_2023-09-28\FSViewer.exe";

        static public async Task OpenInFastStoneExecuted(string fullNamePicture)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = PathToFastStoneExe,
                    Arguments = $"\"{fullNamePicture}\"",
                    UseShellExecute = false
                });

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw;
            }
        }

        static public async Task OpenInFastStoneExecuted2(string fullNamePicture)
        {
            try
            {   
                await Task.Run(() =>
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = PathToFastStoneExe,
                        Arguments = $"\"{fullNamePicture}\"",
                        UseShellExecute = false
                    });
                });

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace P8
{
    class Test
    {
        #region bad
        //public Task ShowAsync()
        //{
        //    return Task.Run(() =>
        //    {
        //        Task.Delay(2000);
        //        throw new Exception("My Own Exception");
        //    });
        //}
        //public async void Call()
        //{
        //    await ShowAsync();
        //} 
        #endregion

        #region good
        public Task ShowAsync()
        {
            return Task.Run(() =>
            {
                try
                {
                    Task.Delay(2000);
                    throw new Exception("My Own Exception");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }); 
        }
        public async void Call()
        {
            try
            {
                await ShowAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
            #endregion
        }
    }

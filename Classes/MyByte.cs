using System.Text;
using MyLibraries.MyEncodingLib.Enums;

namespace MyLibraries.MyEncodingLib.Classes
{
    /// <summary>
    /// Байт
    /// </summary>
    static public class MyByte
    {
        #region Functions
        #region Gets
        /// <summary>
        /// Отримати байти
        /// </summary>
        /// <param name="arrayByte">Поточний масив байтів</param>
        /// <param name="str">Рядок для отримання байтів</param>
        /// <param name="typeEncoding">Тип кодування</param>
        static public void GetBytes(ref byte[] arrayByte, string str, TypeEncoding typeEncoding = TypeEncoding.Default)
        {
            switch (typeEncoding)
            {
                case TypeEncoding.Default:
                    {
                        arrayByte = Encoding.Default.GetBytes(str); return;
                    }
                case TypeEncoding.ASCII:
                    {
                        arrayByte = Encoding.ASCII.GetBytes(str); return;
                    }
                case TypeEncoding.UTF8:
                    {
                        arrayByte = Encoding.UTF8.GetBytes(str); return;
                    }
                case TypeEncoding.UTF32:
                    {
                        arrayByte = Encoding.UTF32.GetBytes(str); return;
                    }
                case TypeEncoding.Unicode:
                    {
                        arrayByte = Encoding.Unicode.GetBytes(str); return;
                    }
            }
        }
        /// <summary>
        /// Отримати байти
        /// </summary>
        /// <param name="arrayByte">Поточний масив байтів</param>
        /// <param name="number">Число для отримання байтів</param>
        /// <param name="typeEncoding">Тип кодування</param>
        static public void GetBytes(ref byte[] arrayByte, int number, TypeEncoding typeEncoding = TypeEncoding.Default) =>
            GetBytes(ref arrayByte, number.ToString(), typeEncoding);
        #endregion Gets
        #endregion Functions
    }
}

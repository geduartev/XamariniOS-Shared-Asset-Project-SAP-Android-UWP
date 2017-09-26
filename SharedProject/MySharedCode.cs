//-----------------------------------------------------------------------
// <copyright file="MySharedCode.cs" company="Ingeniería GD®">
//     Copyright (c) Ingeniería GD® 2017. All rights reserved.
// </copyright>
// <author>Gabriel Eduardo Duarte Vega</author>
// <date>9/25/2017 11:41:40 PM</date>
//-----------------------------------------------------------------------
namespace SharedProject
{
	using System;
	using System.Collections.Generic;
	using System.Text;
    using System.IO;
	
	/// <summary>
    /// Class.
    /// </summary>
    public class MySharedCode
    {
        /// <summary>
        /// Determina la ruta de un archivo dependiendo de la plataforma.
        /// </summary>
        /// <param name="fileName">Nombre del archivo.</param>
        /// <returns>Retona la ruta del archivo.</returns>
        public string GetFilePath(string fileName)
        {
            var FilePath = string.Empty;
#if WINDOWS_UWP
            FilePath = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, fileName);
#endif

#if _ANDROID_
            string LibraryPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            FilePath = Path.Combine(LibraryPath, fileName);
#endif
            return FilePath;
        }
    }
}
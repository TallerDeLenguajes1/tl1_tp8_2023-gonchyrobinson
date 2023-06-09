# LIBRERIA SYSTEM.IO
- Directory.GetFiles(string ruta): Nos devuelve un arreglo de strings con la ruta de cada archivo de la ruta incluyendo carpetas y nombre del archivo
- Directory.GetCurrentDirectory(): Nos devuelve un string con la ruta donde estamos parados (ruta de la carpeta donde esta el Program.cs)
- StreamWriter nombreObjeto = new StreamWriter(rutayNombre del archivo donde queremos escribir). Nos crea un objeto del tipo StreamWriter para que podamos escribir en el archivo
    - objeto.WriteLine(LineasAEscribir): Nos escribe las lineas que necesitamos en el archivo y luego coloca el salto de linea
    - objeto.Close(): Cierra el archivo. Siempre que escribamos en un archivo texto, debemos cerrar el archivo

- Otra funcino que puede ser útil, es la funcion Split(caracter delimitador), que nos permite armar con las partes de un string en un arreglo, donde cada parte del arreglo estará determinada por el delimitador. Un ejemplo de usar esto es:
string rutaMasExt = ruta.Split('.')
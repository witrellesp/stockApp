# Utiliza una imagen base de Windows
FROM mcr.microsoft.com/dotnet/framework/runtime:4.8-windowsservercore-ltsc2019

# Establece el directorio de trabajo
WORKDIR /app

# Copia los archivos binarios precompilados en el contenedor
COPY . /app

# Ejecuta la aplicación
ENTRYPOINT ["appGesTock.exe"]

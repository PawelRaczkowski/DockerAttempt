FROM mcr.microsoft.com/dotnet/core/sdk
RUN mkdir app
WORKDIR /app
COPY . .
RUN dotnet restore
CMD dotnet watch run
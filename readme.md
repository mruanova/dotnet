dot net c#/.net core

brew install openssl

Error: openssl@1.1 1.1.0f is already installed
To upgrade to 1.1.1g, run `brew upgrade openssl@1.1`

ln -s /usr/local/opt/openssl/lib/libcrypto.1.0.0.dylib /usr/local/lib/
ln -s /usr/local/opt/openssl/lib/libssl.1.0.0.dylib /usr/local/lib/

2.2.5 version of .NET Core (not 3)
https://github.com/dotnet/core/blob/master/release-notes/2.2/2.2.5/2.2.5-download.md
SDK Installer1

.net framework 4.8
https://docs.microsoft.com/en-us/dotnet/framework/migration-guide/versions-and-dependencies#net-framework-48

MAC OS:
dotnet --version
3.1.300

UNINSTALL:
curl -O https://raw.githubusercontent.com/dotnet/cli/master/scripts/obtain/uninstall/dotnet-uninstall-pkgs.sh
chmod u+x dotnet-uninstall-pkgs.sh
sudo ./dotnet-uninstall-pkgs.sh

install xcode? (ios)

MYSQL?

brew install mysql

brew services start mysql

mysql -u root -p
(this assumes you have an administrative user "root" with a password of "root").

show databases;

use [database_name];

show tables;

https://www.farces.com/wrestling-with-the-mysql-8-0-11-bear/

nano /usr/local/etc/my.cnf

# Disable default caching_sha2_password
default-authentication-plugin=mysql_native_password

mysql -u root -p

ALTER USER 'root'@'localhost'
  IDENTIFIED WITH mysql_native_password
  BY 'root';

exit

brew services restart mysql

mkdir FirstCSharp
cd FirstCSharp
dotnet new console


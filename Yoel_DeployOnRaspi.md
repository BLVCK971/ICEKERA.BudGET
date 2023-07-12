sudo nano /etc/postgresql/13/main/pg_hba.conf
host    all             all             0.0.0.0/0               md5

curl -sSL https://dot.net/v1/dotnet-install.sh | bash /dev/stdin --channel STS
echo 'export DOTNET_ROOT=$HOME/.dotnet' >> ~/.bashrc
echo 'export PATH=$PATH:$HOME/.dotnet' >> ~/.bashrc
source ~/.bashrc






sudo ufw allow 5000
netstat -lnt
sudo ufw status
dotnet BudGET.Api.dll --urls http://0.0.0.0:5000
curl -L http://localhost:5000/swagger
 which dotnet
sudo nano /etc/systemd/system/ServiceFile.service

[Unit]
Description=ASP .NET Web Application
[Service]
WorkingDirectory=/home/yopi/budGET.NET/
ExecStart=/home/yopi/.dotnet/dotnet BudGET.Api.dll --urls http://0.0.0.0:5000
Restart=always
RestartSec=10
SyslogIdentifier=netcore-demo
User=yopi
Environment=ASPNETCORE_ENVIRONMENT=Production
[Install]
WantedBy=multi-user.target


sudo systemctl enable ServiceFile
sudo systemctl start ServiceFile
- Permet de Logger le Service
journalctl -u ServiceFile.service
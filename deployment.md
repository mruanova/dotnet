# Launch

(Video courtesy of  MicroNugget)

Our first step is to choose what kind of computer we want to buy (we will be choosing the free versions for every option) and turn it on. 

Once we have this computer up and running, then we can connect to it in our next tab. 

Sign up should only take 3-5 minutes. Once done, go to AWS console and log in: aws.amazon.com/console/. 

Choose EC2 under Compute category: 

Once inside the EC2 dashboard, we can launch our instance. Go ahead and click the large blue button that says "Launch Instance'

Choose an Amazon Machine Image (AMI). The machine that we will be using is Ubuntu Server 18.04 LTS (HVM), SSD Volume Type.  

Be sure to choose this exact Ubuntu version! Again, Amazon offers this for free. Click the Select button.

Now we get to choose how powerful we want this computer to be. Let's go with the t2.micro or t1.micro or whatever free instance available. 

Click on 'Next: Configure Instance Details' so that we can make more configurations. We will be using mostly default configurations, but it is good to know what you are able to customize.

We won't be changing any of the default configurations for our instance details. 

Click 'Next: Add Storage'

This is where we want to specify how much storage we want. We get 30 GB for free and amazon has set up an initial storage of 8 GB. We will leave this alone for now. Click on 'Next: Tag Instance' or 'Add Tag'.

We can give our instance a name by 'tagging' it. This is useful to do if you have a lot of instances running, but since this is our first one, we won't tag our instance. 

Go ahead and click 'Next: Configure Security Group'

Now in the Configure Security Group page, you have the option to create a new security group or just use an existing one. 

Let's create a new Security Group and let's name it as "Test Launch" with the description of "Amazon EC2 Test Launch". 

Under this Security Group, The default allowed traffic is SSH with a protocol of TCP, this means that we can only access this instance from our Terminal using SSH. 

In addition to the SSH connection, we need to add HTTP to handle network traffic. Let's add some rules: 


We did this on our local machine as well. For example, we opened up port 5000 to host our web server on our localhost. 

Another example is most websites open up port 80 to handle HTTP requests. 

If you are going to cnn.com, you are going to cnn.com:80 but the browser assumes we are going to that port since we are making an HTTP request. 

We will allow our computer to listen to two different protocols, HTTP and SSH. 

HTTP to properly respond when a client requests something, and SSH which will be used for us to sign in securely

Amazon will warn us that our EC2 instance might not be very secure. Amazon does a great job helping you secure your server. 

However, for our first instance, our EC2 is secure enough. Go ahead and click 'Launch'

One last step, we need to create and download a new key pair. 

Just imagine that you are downloading a virtual KEY in order for you to access your own server. 

The key will be saved with a .pem extension. 

Let's name this key pair as "myfirstinstance" then hit Download Key Pair

Make sure you know where you downloaded your key, our 'myfirstinstance.pem' file. Then, click on 'Launch Instances'

We are so close! It will take only a few seconds for our instance to be set up properly. Click on 'View Instances' to check on the progress of your instance.

Once the Instance State is 'running', find the Public DNS (a URL where others can access the files of this instance, we will change this long URL with our own domain later), copy it, and paste it in your browser. 

This URL will not work yet. We have to connect our instance first using our key 'myfirstinstance.pem' file and install programs to it so that it can be used to host a website. 

But.... CONGRATULATIONS!!!! :) Make sure you celebrate. 

You just launched your first EC2 instance. 

We will connect with this instance on the next tab.

## Connecting (For Mac/Linux)
Let's access this computer. We can access our files on our local machine in two main ways. We can either use a GUI like Finder to see our files or we can use the terminal to access the file structure of our computer. To access our EC2 instance, we are going to use our terminal. This is really cool. It's as if we are right next to the EC2 instance that we bought, and we are running the terminal application on that computer. This also means that we won't have access to a GUI like Finder to access the file structure so it is crucial that we know general terminal commands to navigate the files. Fortunately, Ubuntu is very similar to Macs and most of the commands that we are familiar with will be the same.

Run this command to connect to your EC2. You connect using ssh command, specifying where your key file is, then specifying your user name (username will be ubuntu) followed by an @ sign and your server's public IP address.



Your computer will ask you if you really want to access this computer. Type in yes and click enter.


The ssh command may not work due to file permissions.



Run the following command to allow ssh to connect: chmod 400 yourPemFileName.pem

Then let's run the ssh command again.


Congratulations! We have successfully connected with our remote EC2 instance. Notice how the terminal prompt now displays Ubuntu. Make sure you celebrate!

## Connecting (For PC)
Let's access this computer.  

Unlike our local machine, where we can use GUI-like Finder to see our files, we will need to use a terminal to access the file structure of this remote computer.  

It's as if we are right next to the EC2 instance that we bought, and we are running the terminal application on that computer. 

This also means that we won't have access to a GUI like Finder to access the file structure so it is crucial that we know general terminal commands to navigate the files, the terminal Ubuntu uses is bash - the same terminal application used by macs.  

Most of these aren't too different from those that you would use in Powershell or CMD, but if you follow the steps closely, you should have no problem.

The tricky thing for WIndows users, is being able to access the SSH protocol from a windows console - the easiest way to do this is with GitBash.

### GitBash
You can install a bash emulator from git (you may have this already) to perform the required SSH command.  

Once you've finished the installation, you can open a GitBash terminal that looks like this:

## Connect to your Ubuntu Instance
Using your GitBash terminal, navigate to where your .pem file is located.  

This will download to your /Downloads directory, but it's best to keep it somewhere more safe/easy to remember.  

Here, I have moved this file to a /Dojo directory.

From your AWS console, find the Public DNS for your instance.  

Look for the lower panel, after selecting your instance from other's you may have there.

Run the following command, replacing "myfirstinstance.pem" with the name that you have chosen, and the Public DNS with what was issued to you by AWS.  

It will ask you if you want to verify the host, just type yes.

    ssh -i YOUR_PEM_NAME.pem ubuntu@YOUR_PUBLIC_DNS

## Install
Remember when we had to install a bunch of stuff to set up our development environment on our computer? 

We have to do the same for this EC2 instance. 

It only has some basic programs installed. 

We already have Ubuntu installed, the operating system we chose when we launched our instance, which is a flavor of Linux. 

We will have to download dotnet just like before and also nginx which is a web server that will serve responses to our users' requests. 

We also have to download and configure MySQL for database storage manually (No MAMP to help us out here!).

Note: Make sure you are logged in to your ubuntu computer (terminal for Mac, GitBash for Windows)

### Before you proceed any further:
it is VERY IMPORTANT that you stop and read all the instructions as you go through deployment. 

Many students have a tendency of zeroing in on the copy-and-paste-able lines and not reading the content around it, which results in errors as steps are missed. 

Take your time, or you'll end up having to completely start over your deployment!

### Nginx
First, let's make sure all of our packages are up to date by running this command:

    sudo apt-get update

Now run this command to get going and install nginx:

    sudo apt-get install nginx

We mentioned that nginx is a web server that will handle our users' requests and responses, but doesn't Kestrel already do that for us? 

Kestrel is indeed a web server in its own right and does also perform this functionality, but it only runs on localhost, it does not know how to handle requests outside the 127.0.0.* band. 

That is where nginx comes in. We use nginx, in a sense, to sit on top of our dotnet app running Kestrel as a reverse proxy to direct external requests to our Kestrel instance and to take any response  Kestrel might give and bounce them from Kestrel back out. 

So with nginx now installed, we need to configure it to have this connection to our Kestrel server.

Go ahead and open the nginx configuration file found at /etc/nginx/sites-available/default in either Vim or Nano. 

Use whichever editor you feel comfortable with. If you have not used either, or cannot remember how to use one, here are some brief instructions on how to use vim:

After you sudo vim into a file, press the "i" key to be able to insert text into the document. 

(The word --INSERT-- should appear at the bottom of the screen.) At this point you will need to use your arrow keys to move around the document. 

When you have made the necessary changes, press the Esc key, followed by :wq and press enter. "w" is to save your file, "q" is to quit out of vim.
```
sudo rm /etc/nginx/sites-available/default
sudo vim /etc/nginx/sites-available/default
```
and paste in the following code
```
server {
    listen 80;
    location / {
        proxy_pass http://localhost:5000;
        proxy_http_version 1.1;
        proxy_set_header Upgrade $http_upgrade;
        proxy_set_header Connection keep-alive;
        proxy_set_header Host $host;
        proxy_cache_bypass $http_upgrade;
    }
}
```
Now, whenever traffic comes over the default HTTP port of 80 it will be directed to localhost port 5000 where kestrel is running and vice versa. 

All we need to do from here is run

    sudo service nginx restart

to get it working with this new configuration and we are done.

### MySQL
Next, let's move on to getting our MySql database server installed and setup.

Install MySql Server to your EC2 instance using the following command.
```
sudo apt update
sudo apt install mysql-server -y
sudo mysql
```
Once inside the MySQL shell enter the following SQL commands....
```
ALTER USER 'root'@'localhost' IDENTIFIED WITH mysql_native_password BY 'root';
FLUSH PRIVILEGES;
exit;
```
Important: set the password to the one you want to use when connecting to your project.

We now have a MySQL server installed, but to get the tables for our application up to MySQL, we will use dotnet Code First migrations to do the heavy lifting.  

Once we get our dotnet SDK software installed, we can complete this step.

### Dotnet
At this point, we've set up our EC2 instance, installed and configured nginx, and setup a database server.

We are ready to move on to the final and most crucial component of having our app deployed to the web: getting dotnet on our server instance.

From here, our project is good to go and can be sent to our deployment server. In this case, we will be using git to transfer the code base over. 

Make sure your server has git installed by running sudo apt-get install git .

### .gitignore

If you have not already done so at this point, it is advisable to create a .gitignore file in your project so that your appsettings.json file is not uploaded to the internet. 

Especially if your userid and password are anything other than "root". 

(Remember before when we talked about the security issues of people being able to see your password?) 

We will be able to put this information back in from the remote server, so we won't lose anything. 

To make a .gitignore, either open your project in your text editor or navigate to it in a separate terminal from the one that is currently running your deployment server. 

In the root project directory, make a file called .gitignore (the . before is very important, make sure your file is not accidentally saved as a .txt or anything else.) 

Inside the file, add this line of code:

### appsettings.json
That is all we need to make sure that when we upload our project to Github in the next step that our sensitive data isn't being uploaded as well.

With that done, we can proceed to uploading to Github:

Push your local app to Github or an appropriate remote repository.

Initialize an empty git repo at the root of your project directory.

Add and Commit your changes

Have a repo at GitHub ready to go (Tip: to make setup later easier, give your repo the same name as whatever you called your project)

Push your local changes to your remote GitHub repo (check to see that your gitignore worked and the file is not there)

Navigate to /var/www on your remote server

Using the link to you remote repository copy the files to the remote using

    sudo git clone <remote_repo_url>

Now that we have our code on our server, we need to grant permissions to this new directory to our EC2 instance users.

    sudo chown -R ubuntu <new_dir_name>

### appsettngs.json

If you have properly included your appsettings.json file in your GitHub repo's .gitignore file, it will be absent from your project once you have cloned it. 

In which case you will just have to add this file back in using vim/nano to your project's working directory, where it exists in your local project (next to your .csproj file, etc). 

Navigate to this directory (you can simply cd into it like you would in a normal terminal), and copy the contents of your local appsettings file. 

A few things to be aware of:

This connection string is hooking up to the MySQL installed on your remote server. 

This is NOT your personal version. As such, you must be aware of these potential difference:

Userid: will be root, this is the default user for MySQL.

Password: will be whatever password you put in when you installed MySQL earlier on the remote server. (Ideally, you should have called it "root".)

Port: will be 3306. If you are using MAMP or had to make any changes to your port in order to get MySQL to work on your local computer, those things will not be present in the remote server. 

Database: will be whatever you called your database locally. 
```
sudo vim appsettings.json
{
  "DBInfo":
  {
      "Name": "MySQLconnect",
      "ConnectionString": "server=localhost;userid=root;password=YOUR_PASSWORD;port=3306;database=YOUR_DB_NAME;SslMode=None"
  }
}
```
### Download Dotnet SDK
All that is left to do now is run it! To do so, the final step is to install the dotnet SDK to provide us the needed terminal commands.

Download a Mircosoft product key

    sudo wget -q https://packages.microsoft.com/config/ubuntu/16.04/packages-microsoft-prod.deb

Register the Microsoft packages to the package manager

    sudo dpkg -i packages-microsoft-prod.deb

Now, run the following commands to update the package manager with the newly registered packages

    sudo apt-get install apt-transport-https
    sudo apt-get update

Now we can download the dotnet SDK!

    sudo apt-get install dotnet-sdk-2.2

Migrate/Update your database tables

Now that we have the dotnet SDK software installed, we can complete the job of getting our database tables in our MySQL database server.  

Navigate to your project's working directory (cd <YourRepoName>) and run the following commands to complete this crucial step:
```
dotnet restore
dotnet ef migrations add MigrationName
dotnet ef database update
```
Now, we can run  dotnet run to get our app up and running. 

We can make sure that it all worked out as intended by navigating to the public IP of the server and we should see our running application. 

However, if you were to close your Ubuntu terminal now, your app would stop running on the EC2 instance! 

In the next section, we'll learn how to keep our project running even after we end our connection.

Go ahead and stop dotnet from running (a simple CTRL + c will do) and head to the next section. We're almost done!

## Supervisor
By default, ASP.NET Core apps always run in the foreground. 

This means that the terminal can't do anything else while the app is running, and it also means the terminal can't be closed without stopping our project. 

We can't leave our Ubuntu connection terminal open forever, and we wouldn't want to anyway. 

The solution is to run our app as a Daemon. 

A Daemon is a process that runs in the background without us needing to maintain constant control over it. 

In order to Daemonize our app, we're going to use a process manager called Supervisor.

First, we need to install Supervisor:

    sudo apt-get install supervisor

Next, we need to publish our app. Navigate to your project on the server and run

    dotnet publish

The publish command creates all the files needed for our app to run in a deployment environment (when we deployed to Azure, it ran publish for us).

Next, we need to tell Supervisor how to run our published app. Navigate to Supervisor's configuration folder:

    cd /etc/supervisor/conf.d

Now we can create the configuration for our specific project. 

Use sudo Vim or Nano to create and start editing the file in one command:

    sudo vim yourprojectname.conf

Add the following code to the new file, substituting the name of your App and Repo:

yourAppName is the name of your project's .csproj file.

yourRepoName is the name of your project's directory.
```
[program:yourAppname]
command=/usr/bin/dotnet  /var/www/yourReponame/bin/Debug/netcoreapp2.2/publish/yourAppname.dll
directory=/var/www/yourReponame/bin/Debug/netcoreapp2.2/publish
autostart=true
autorestart=true
stderr_logfile=/var/log/yourAppname.err.log
stdout_logfile=/var/log/yourAppname.out.log
environment=ASPNETCORE_ENVIRONMENT=Production
user=www-data
stopsignal=INT
```
Now when we restart Supervisor, this conf file provides instructions for how to start our app as a background process.

    sudo service supervisor restart

And that's it! If we visit our public IP address we should see our app running, even if we close our ubuntu terminal.

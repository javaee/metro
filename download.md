# Metro 2.3.1

Release Date: January 15, 2015

## Downloading Metro 2.3.1

Unless you have already done so, please download the [Metro 2.3.1 ZIP archive](https://maven.java.net/content/repositories/releases//org/glassfish/metro/metro-standalone/2.3.1/metro-standalone-2.3.1.zip). Once downloaded, you can expand it by executing following shell command:

    unzip metro-standalone-2.3.1.zip

On Windows or Mac, you may as well just double-click the zip file to expand it.

The expanded metro directory contains following ant files:

* metro-on-tomcat.xml
* metro-on-glassfish.xml

These files are used to install the Metro binaries into the respective web containers. The installation procedure is explained in the next section.

## Installing Metro 2.3.1

### GlassFish 4.x

GlassFish bundles Metro by default. You should not update Metro version separately - always update to full Glassfish update.

In case you want to experiment with an unofficial build or release of Metro, you may try the GlassFish installer. To stop GlassFish instance, install Metro 2.3.1 using the standalone installer on top of it and restart the GlassFish instance, execute the following commands:

    asadmin stop-domain <domain-name>
    ant -Das.home=<GF_INSTALL_DIR> -f <METRO_INSTALL_DIR>/metro-on-glassfish.xml install
    asadmin start-domain <domain-name>
        
### Tomcat

The installation process for Tomcat is very similar to that of GlassFish. Again, the top-level directory of the Tomcat installation is passed as an argument to the ant command. To shutdown Tomcat, change directories, invoke ant, and restart Tomcat by executing these commands:

    catalina.sh stop
    ant -Dtomcat.home=<TOMCAT_INSTALL_DIR> -f <METRO_INSTALL_DIR>/metro-on-tomcat.xml install
    catalina.sh start
        
For Tomcat, the installation process copies the two Metro jar files into Tomcat's shared/lib directory. No Tomcat configuration files are modified.

## Updating to Metro 2.3.1

Once a version of Metro web services stack has been installed on a web container, it can be updated with a new version of the Metro binaries. To update your Metro installation to Metro 2.3.1, follow the same steps used for the initial install, shown above.

## Uninstalling Metro

To remove the Metro binaries and configuration changes from your web container, the steps are almost identical to the ones in the installation process. The following steps will restore your web container to the state before Metro installation:

### GlassFish

    asadmin stop-domain <domain-name>
    ant -Das.home=<GF_INSTALL_DIR> -f <METRO_INSTALL_DIR>/metro-on-glassfish.xml uninstall
    asadmin start-domain <domain-name>
            
### Tomcat

catalina.sh stop
ant -Dtomcat.home=<TOMCAT_INSTALL_DIR> -f <METRO_INSTALL_DIR>/metro-on-tomcat.xml uninstall
catalina.sh start
            
## Users Guide

We have created a [snapshot of Metro Users Guide](https://javaee.github.io/metro/doc/user-guide/user-guide.pdf) at the time of this Metro release. You may also wish to consult [the latest version](https://javaee.github.io/metro/doc/user-guide/user-guide.pdf) of the Metro Users Guide.

## Technical Support

Please [subscribe to the users list](https://javaee.groups.io/g/metro) and send comments/feedbacks/opinions to the [list](https://javaee.groups.io/g/metro). Additionally, we encourage you to report any bugs you might find while using Metro through our Metro [issue trackers](https://javaee.github.io/metro/issues).

## Workspace Snapshot

If you'd like to hack the source code used to build these binaries, please check out the Metro sources from [here](https://javaee.github.io/metro/sources).
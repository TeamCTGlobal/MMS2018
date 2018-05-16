# Running Deployments

Screenshots:

![Alt text](https://github.com/TeamCTGlobal/MMS2018/blob/master/RunningDeployments/r1.png?raw=true "Running Deployments")

![Alt text](https://github.com/TeamCTGlobal/MMS2018/blob/master/RunningDeployments/r2.png?raw=true "Running Deployments - Details")

Installation:


1) Download and install 2Pint Free Dashboard for showing running deployments - Link will be up when it's GA soon!
   You need a webserver here.

2) Copy RunningDeployments.dll and RunningDeployments.config from Install folder to SCCM bin folder: C:\Program Files (x86)\Microsoft Configuration Manager\AdminConsole\bin
for every clients running the console

3) Copy the folder 01d5609d-b0d4-42ea-a7eb-8c74f9825c92 with the RunningDeployments.xml file to C:\Program Files (x86)\Microsoft Configuration Manager\AdminConsole\XmlStorage\Extensions\Nodes

4) Open RunningDeployments.config and change the targetURL to your own webserver

5) Enjoy!








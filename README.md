# Countries_tradePartners_AVL-Tree
C# AVL Tree using windows forms

--University Description--
<b>MANCHESTER METROPOLITAN UNIVERSITY</b><br/>
<b>Division of Computer Science and Information Systems</b><br/><br/>
This assignment is based on a simplified version of a real world  problem. It is not uncommon to be asked to produce applications similar to this in industry, normally as a pilot study. It is not uncommon for files to differ slightly from the provided specification making error trapping important, however that isn’t the case with this file.<br/><br/>
<b>International Trading Data</b><br/><br/>
A large multinational trading company has acquired a flat data file of economic data for different countries. You have been asked to create an application that will store and structure this data to allow fast and efficient searching (and
other functionality) via the country name. You are to implement an object-oriented application, where each object corresponds to a specific country and its economic data. The application must be able to read this data from csv file documents where each line in the file corresponds to a unique country.<br/>
The first line of the file consists of the following headings:<br/>
<b>Country,GDP growth,Inflation,Trade Balance,HDI Ranking,Main Trade Partners</b><br/>
Other lines consist of the data which falls under each heading, for example:<br/>
<b>USA,1.8,2,-3.1,4,[Canada;UK;Brazil]</b><br/>
Note that the last field (Trade  Partners) is a list of country names separated by ‘;’ and enclosed in ‘[]’.<br/>
This field will contain an arbitrary (varying) number of count.<br/>
You must implement an application with a GUI (may be multiple forms) which allows the user to:<br/>  
1.Load a text file and store country information with in the tree<br/>
2.Manually edit country information<br/>
3.Display the number of unique countries with in the tree and the depth of the tree<br/>
4.Remove a country<br/>
5.Display all country names in alphabetic order.<br/>
6.a) Search for a country (display all country information)<br/>
b) Partial keyword search by country name, as letters are entered any countries starting with those letters are shown and can be selected from.<br/>
7.Search for and display ALL countries who trade with a particular country<br/>
8.Display the country which has the biggest potential for trade.A country’s potential for trade can be found by summing the GDP growth attribute’s for all its trading partners<br/><br/>
Credit will be given for<br/>
•OO design - Complete and Working Classes<br/>
•Working Implementation<br/>
•Usability of the GUI<br/>
•Efficiency of your search algorithms<br/>
•Tested code – you can include a file of tests (Blackbox testing)<br/>
•Validation<br/>
•Refactored code<br/>

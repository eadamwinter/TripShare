# TripShare

<p>My web application based on an app that once I was using on my phone to share costs of some mountain trip.
I was intrested how it works so I decided to write one on my own using .NET Core 3.1.</p>

<p>TripShare allows to add group of friends, add expenses and then calculate the results (debts between members of the group). There is also a possibility to edit
or remove expenses and groups.</p>

During the work on this project I practiced :
<ol>
<li>ASP.NET Core/C#</li>
<li>Entity Framework Core</li>
<li>Unit tests (Including using InMemory database tests)</li>
<li>Bootstrap</li>
<li>Javascript/jQuery/DOM</li>
<li>Ajax</li>
<li>CSS/HTML</li>
</ol>

<h3>Algorithm</h3>

<ol>

<li>
  Firstly a dictionary is created containing names splitted by underline symbol as a key and a number (meaning how much money the member with the first name owns to the other) as a value. One dictionary element could look like this: {Adam_Jacek, 20}.
</li><br />

<li>
  Then all spare elements from the dictionary must be erased. For example elements with the same value but the opposite key (Adam_Jacek Jacek_Adam).
</li><br />

<li>
  Finally the dictionary is optimized by looking for possibility to reduce its elements, for example:
  <br />

  
  <b>if</b>
  <p>person A owns money to person C.</p>
  <p>person B also owns money to person C.</p>
  
  <p>person A owns money to person B and the value is equal or less then value that person B owns to person C</p>
  
  <b>then</b> 
  <p>person A can take into his account debt of person B. </p>
  
  <p>It rases the value that person A owns to person C, reduces the value that person B owns to person C and consequently removing from the dictionary one or two elements:
  </br>
  <i>Element with debt between person A and B.</i>
  </br>
  <i>Element with debt between person B and C if the value after reducing equals 0.</i>
  </p>
</li>
</ol>

<p>
  <b>Code you can find in TripShare project in classes Calculation, CalculationMethod and Optimizer.</b>
</p>

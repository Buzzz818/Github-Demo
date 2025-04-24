using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Github_Demo
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnSolution68.Style.Add("background-color", "#A67C84");
            btnSolution68.Style.Add("color", "white");
            btnSolution68.Style.Add("border-color", "#A67C84");

            btnSolution123.Style.Add("background-color", "#99AABF");
            btnSolution123.Style.Add("color", "white");
            btnSolution123.Style.Add("border-color", "#99AABF");

            btnSolution2338.Style.Add("background-color", "#B4BFB5");
            btnSolution2338.Style.Add("color", "white");
            btnSolution2338.Style.Add("border-color", "#B4BFB5");

            btnSolution51.Style.Add("background-color", "#808C74");
            btnSolution51.Style.Add("color", "white");
            btnSolution51.Style.Add("border-color", "#808C74");

        }
        protected void btnClear_Click(object sender, EventArgs e)
        {
            lblSolutionText.Text = "";
        }

        protected void btnSolution68_Click(object sender, EventArgs e)
        {
            var testCase = new LeetCode68();
            var testCase1 = testCase.FullJustify(new string[] { "This", "is", "an", "example", "of", "text", "justification." }, 16);
            var testCase2 = testCase.FullJustify(new string[] { "What", "must", "be", "acknowledgment", "shall", "be" }, 16);
            var testCase3 = testCase.FullJustify(new string[] { "Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.", "Art", "is", "everything", "else", "we", "do" }, 20);
            lblSolutionText.Text = $@"
<h3>68. Text Justification</h3>
Given an array of strings <b>words</b> and a width <b>maxWidth</b>, format the text such that each line has exactly <b>maxWidth</b> characters and is fully (left and right) justified.<br /><br />
You should pack your words in a greedy approach; that is, pack as many words as you can in each line. Pad extra spaces '&nbsp;' when necessary so that each line has exactly <b>maxWidth</b> characters.<br /><br />
Extra spaces between words should be distributed as evenly as possible. If the number of spaces on a line does not divide evenly between words, the empty slots on the left will be assigned more spaces than the slots on the right.<br /><br />
For the last line of text, it should be left-justified, and no extra space is inserted between words.<br /><br />
<b>Note:</b><br />
- A word is defined as a character sequence consisting of non-space characters only.<br />
- Each word's length is guaranteed to be greater than 0 and not exceed <b>maxWidth</b>.<br />
- The input array <b>words</b> contains at least one word.
<br/>
<br/>
Test Case 1: words =
[""This"", ""is"", ""an"", ""example"", ""of"", ""text"", ""justification.""] 
|
Test Case 2: words =
[""What"",""must"",""be"",""acknowledgment"",""shall"",""be""]
|s
Test Case 3: words =
[""Science"",""is"",""what"",""we"",""understand"",""well"",""enough"",""to"",""explain"",""to"",""a"",""computer."",""Art"",""is"",""everything"",""else"",""we"",""do""]
<br/>
<br/>
<h3>Results</h3>
<br/>
Test Case 1: [{string.Join(", ",testCase1)}]
|
Test Case 2: [{string.Join(", ", testCase2)}]
|
Test Case 3: [{string.Join(", ", testCase3)}]
";
        }

        protected void btnSolution123_Click(object sender, EventArgs e)
        {
            var testCase = new LeetCode123();
            var testCase1 = testCase.Solution(new int[] { 3, 3, 5, 0, 0, 3, 1, 4 });
            var testCase2 = testCase.Solution(new int[] { 1, 2, 3, 4, 5 });
            var testCase3 = testCase.Solution(new int[] { 7, 6, 4, 3, 1 });
            lblSolutionText.Text = $@"
<h3>123. Best Time to Buy and Sell Stock III</h3>
Given an array prices where prices[i] is the price of a given stock on the ith day, find the maximum profit you can achieve. You may complete <b>at most two transactions</b>.<br /><br />
<b>Note:</b> You may not engage in multiple transactions simultaneously (i.e., you must sell the stock before you buy again).
<br/>
<br/>
Test Case 1: prices = [3, 3, 5, 0, 0, 3, 1, 4]
|
Test Case 2: prices = [1, 2, 3, 4, 5]
|
Test Case 3: prices = [7, 6, 4, 3, 1]
<br/>
<br/>
<h3>Results</h3>
<br/>
Test Case 1: {testCase1}
<br/>
Explanation:</b> Buy on day 4 (price = 0) and sell on day 6 (price = 3), profit = 3-0 = 3. Then buy on day 7 (price = 1) and sell on day 8 (price = 4), profit = 4-1 = 3.
<br/>
<br/>
Test Case 2: {testCase2}
<br/>
Explanation:</b> Buy on day 1 (price = 1) and sell on day 5 (price = 5), profit = 5-1 = 4. Note that you cannot buy on day 1, buy on day 2 and sell them later, as you are engaging multiple transactions at the same time. You must sell before buying again.
<br/>
<br/>
Test Case 3: {testCase3}
<br/>
Explanation:</b> In this case, no transaction is done, i.e., max profit = 0.
";


        }

        protected void btnSolution2338_Click(object sender, EventArgs e)
        {
            lblSolutionText.Text = "Solution #2338: Optimized linear approach with O(m+n) complexity.";
        }

        protected void btnSolution51_Click(object sender, EventArgs e)
        {
            lblSolutionText.Text = "Solution #51: Brute force - combine, sort, and compute median.";
        }        
    }
}
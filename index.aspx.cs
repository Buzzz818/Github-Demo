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
|
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
            lblSolutionText.Text = "Solution #123: Use binary search to partition arrays and find median.";
        }

        protected void btnSolution3382_Click(object sender, EventArgs e)
        {
            lblSolutionText.Text = "Solution #3382: Optimized linear approach with O(m+n) complexity.";
        }

        protected void btnSolution420_Click(object sender, EventArgs e)
        {
            lblSolutionText.Text = "Solution #420: Brute force - combine, sort, and compute median.";
        }        
    }
}
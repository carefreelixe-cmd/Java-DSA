/*Problem Statement :

After JEE Mains, some students got admission into an engineering college. Now there is a class consisting of such n students, and the HOD came to say it is time to select the class monitor. But He never gets all of them at one time. So he brought a register, every time he gets someone with less rank than the previous time he cut the name and wrote the name of the student and the rank.
For a given number of ranks he gets each time, you have to predict how many names are cut in the list.

Constraints:
Number of Visiting<=10^9
ranks <=10000

Input Format:
Number of Visiting N in their first line
N space separated ranks the HOD gets each time

Output Format:
Number of ranks cut in the list

Sample Input:
6
4 3 7 2 6 1

Sample Output:
3 */

package Practice.Soumadip.Deloitte;
import java.util.*;

public class ClassMonitor {

      public static int countCuts(int[] ranks) {
            int n = ranks.length;
            int count = 0;
            int x=Integer.MAX_VALUE;
            for (int i = 0; i < n - 1; i++) {

                  if ((ranks[i] > ranks[i + 1]) && (x > ranks[i + 1])) {
                        count++;
                        x = ranks[i + 1];
                  }
            }
            return count;

      }

     // Auto test runner (DO NOT MODIFY)
public static void main(String[] args) {
    boolean allPassed = true;

    // Test case 1
    int[] test1 = { 4, 3, 7, 2, 6, 1 };
    int expected1 = 3;
    int result1 = countCuts(test1);
    if (result1 != expected1) {
        allPassed = false;
        System.out.println("Test 1 FAILED: Expected " + expected1 + ", Got " + result1);
    } else {
        System.out.println("Test 1 PASSED: Got " + result1);
    }

    // Test case 2
    int[] test2 = { 5, 1, 2, 0 };
    int expected2 = 2;
    int result2 = countCuts(test2);
    if (result2 != expected2) {
        allPassed = false;
        System.out.println("Test 2 FAILED: Expected " + expected2 + ", Got " + result2);
    } else {
        System.out.println("Test 2 PASSED: Got " + result2);
    }

    // Test case 3
    int[] test3 = { 4, 5, 10, 9, 2, 3, 6 }; // new test case
    int expected3 = 1;
    int result3 = countCuts(test3);
    if (result3 != expected3) {
        allPassed = false;
        System.out.println("Test 3 FAILED: Expected " + expected3 + ", Got " + result3);
    } else {
        System.out.println("Test 3 PASSED: Got " + result3);
    }

    if (allPassed) {
        System.out.println("ALL TESTS PASSED");
    } else {
        System.out.println("SOME TESTS FAILED");
    }
}
}
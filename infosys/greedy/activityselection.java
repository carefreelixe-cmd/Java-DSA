package greedy;


//algorithm


// Sort activities by finish time

// Pick the first activity

// Select next activity whose start ≥ last selected finish


import java.util.*;
public class activityselection{
    public static void main(String[] args) {
        int start[]={1,3,0,5,8,5};
        int end[]={2,4,6,7,9,9};

        //end time basis sorted


        int maxAxt=0;//Because we always select the first activity.
        //Select the activity that finishes earliest first
        ArrayList <Integer> asn=new ArrayList<>();
        maxAxt=1;
        asn.add(0);//asn stores which activities we selected.
        int lastEnd=end[0];//We selected A0, so the last finishing time is:

        for(int i=1;i<end.length;i++)
        {
            if(start[i]>=lastEnd)
            {
                maxAxt++;
                asn.add(i);
                lastEnd=end[i];
            }
        }
System.out.println("max activities="+maxAxt);
for(int i=0;i<asn.size();i++)
{
    System.out.println("A"+asn.get(i)+" ");

}

System.out.println();

    }
}
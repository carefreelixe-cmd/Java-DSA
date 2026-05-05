package greedy;

import java.lang.reflect.Array;
import java.util.Arrays;

public class jobschudeling {
    int id,int deadline,int profit;
    Job(int id,int deadline,int profit)
    {
        this.id=id;
        this.deadline=deadline;
        this.profit=profit;
    }

    public class Innerjobschudeling {
    
        public static void main(String[],args)
        {
            Job[]jobs={
                 new Job(1, 2, 100),
            new Job(2, 1, 50),
            new Job(3, 2, 10),
            new Job(4, 1, 20)
            }
            //sort the job according to profit
            Arrays.sort(jobs,(a,b)->b.profit-a.profit);
            //find the max deadline
            int maxDeadLine=0;
            for(Job job:jobs)
            {
                maxDeadLine=Math.max(maxDeadLine, job.deadline);
            }
            int []slot=new int[maxDeadLine+1];
            //fill the slsot with -1;
            Arrays.fill(slot,-1);

            //make total profit 0
            int totalProfit=0;

            //now caluta the total profit4for(jobs)

            for(Job job:jobs)
            {
                for(int j=job.deadline;j>0;j--)
                {
                    if(slot[j]==-1)
                    {
                        slot[j]=job.id;
                        totalProfit+=job.profit;
                        break;
                    }
                }
            }
            System.out.println("Total Profit",totalProfit);
System.out.print("Jobs done :");
for(int i=1;i<=maxDeadLine;i++)
{
    if(slot[i]!=-1)
    {
        System.out.print("j"+slot[i]+" ");
    }
}

        }
    }
}

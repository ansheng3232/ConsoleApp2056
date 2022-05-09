// See https://aka.ms/new-console-template for more information
#include <stdio.h>
int main()
{
    int in ;
    float i = 0 ,key, sum =0;
	while(true){/*死循环*/
	    scanf("%d",&in);
	    if (in == -1){/*对输入的值进行判断*/
	        break;/*跳出while循环*/
	    }
	    sum = sum + in;
	        i = i + 1;
	}
	if (i != 0){/*对计数i的数值进行判断,如果有则输出平均数key，如果没有数据（指第一个数据就输入了-1）则输出无数据*/
	    key = sum/i;
	    printf("%.2f",key);
	}
	else{
	    printf("无数据");
	}
return 0;
}
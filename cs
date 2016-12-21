#include <bits/stdc++.h>
#define M 1000000007
#define N 100000
using namespace std;
int main()
{
    int t;
    cin>>t;
    int coins[8]= {1,2,5,10,20,50,100,200};
    while(t--)
    {
	int n;
	cin>>n;
	long long ways[N+1] = {0};
	ways[0] = 1;
	for(int i=0; i<8; i++)
	{
	    for(int j=coins[i]; j<=n; j++)
	    {
		ways[j] += (ways[j-coins[i]])%M;
	    }
	}
	cout<<(ways[n])%M<<endl;
    }
}

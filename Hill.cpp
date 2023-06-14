#include <stdio.h>
#include <iostream>

using namespace std;
#include <string.h>
#include <conio.h>

void  xuat( char A[]);
void mahoa(char A[],int key[][100],int l,int z,char in[],char out[],int &n,int a);
void giaima(char A[],int key[][100],int l,int z,char in[],char out[],int &n,int a);
int gcd(int a, int b);
void  nhap(int A[][100],int &n);
void  xuatmangint( int A[][100],int n);
int dinhthuc(int k[][100] );
int * tichMaTran(int a[][100], int b[][100], int m, int n);
int timvitri(char a, char A[]);
int Knghichdao(int m,int n);
void  nhap1( int A[][100],int n,int a,int b);



int main()
{	 
	Knghichdao(5,12);
	
	
//	char A[26]={'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
//	int k[100][100];
//	int z=0;
//	char in[100];
//	char out[100];
//	int test;
//
//		cout<<"Moi ban nhap chuoi dau vao "; 
//		fgets(in,100,stdin);
//		int l=strlen(in);
//
//	int n;
//	
//	int a,b,c,d;
//	cout<<"key la ma tran ?x? : ";
//	cin>>n;
//	cout<<"Moi ban nhap khoa K ";
//	nhap(k,n);
//	int f=0;
//	d=gcd(dinhthuc(k),26);
//	
//	if(d==1)
//		{
//			cout<<"Chon 1 de Ma Hoa, 0 de Giai Ma ";
//			cin>>a;
//		if(a==1)
//		{	
//			mahoa(A,k,l,z,in,out,n,f);
//			xuat(out);
//		}
//		else{
//			int nghichdao=Knghichdao(dinhthuc(k));
//			swap(k[0][0],k[1][1]);
//			k[1][0]*=(-1);
//			k[0][1]*=(-1);
//			for(int i=0;i<n;i++){			 
//		        for(int j=0;j<n;j++) {
//		        
//				while (k[i][j]<0){
//					k[i][j]+=26; 
//				} 	
//		     	k[i][j]=(k[i][j]*nghichdao)%26;
//			    }
//		    }
//			giaima(A,k,l,z,in,out,n,f);	
//			xuat(out);
//		}	
//	}
//	else
//	{
//			cout<<"Ma K Khong Hop Le :";
//	}  
//    
}

//void mahoa(char A[],int key[][100],int l,int z,char in[],char out[],int &n,int a){
//	
//		int b[1][2];
//		int c[100][100];
//
//	if(a%n==0 && a<l-1)
//	{	
//			int i, j, k;
//					
//			b[0][0]=timvitri(in[a],A);
//			b[0][1]=timvitri(in[a+1],A);
//			xuatmangint(key,2);
//			 for(i=0;i<1;i++){			 
//		        for(j=0;j<n;j++) {
//		         int tt=0;
//		           for(k=0;k<n;k++)
//		               {
//		                  tt = (tt + (b[i][k] * key[k][j]))%26;		                  
//		                }
//		            c[i][j] = tt;    
//					     					 
//			}
//			
//					out[a]=A[c[0][0]];
//					out[a+1]=A[c[0][1]];
//			}		
//				
//			mahoa(A,key,l,z,in,out,n,a+n);
//	}
//	
//	
//	
//}
		


//void giaima(char A[],int key[][100],int l,int z,char in[],char out[],int &n,int a){
//
//		int b[1][2];
//		int c[100][100];
//
//	if(a%n==0 && a<l-1)
//	{	
//			int i, j, k;
//					
//			b[0][0]=timvitri(in[a],A);
//			b[0][1]=timvitri(in[a+1],A);
//
//			 for(i=0;i<1;i++){			 
//		        for(j=0;j<n;j++) {
//		         int tt=0;
//		           for(k=0;k<n;k++)
//		               {
//		                  tt = (tt + (b[i][k] * (key[k][j])))%26;
//		                }
//		            c[i][j] = tt;         					 
//			}
//			
//					out[a]=A[c[0][0]];
//					out[a+1]=A[c[0][1]];
//			}		
//				
//			mahoa(A,key,l,z,in,out,n,a+n);
//	}
//	
//
//}
void  xuat( char A[])
{
	for (int i=0;i<100;i++){
		cout<<A[i];		
	}
}
void  nhap( int A[][100],int &n)
{
	
	
	for (int i=0;i<n;i++){
		for(int j=0;j<n;j++)
		{
		
		cin>>A[i][j];	
	}
	}
}
void  nhap1( int A[][100],int n,int a,int b)
{
	
	
	for (int i=a;i<n;i++){
		for(int j=0;j<n;j++)
		{
		
		A[i][j]=b;	
	}
	}
}

void  xuatmangint( int A[][100],int n)
{
	for (int i=0;i<2;i++){
			for(int j=0;j<n;j++)
		{
		cout<<A[i][j]<<" ";		
		}
		
	}
}

int gcd(int a, int b){
    if (a == 0 || b == 0){
        return a + b;
    }
    while (a != b){
        if (a > b){
            a -= b;
        }else{
            b -= a;
        }
    }
    return a; 
}

int timvitri(char a,char A[])
{
for (int j=0;j<26;j++){		
		if(a==A[j]){
		return j;
}
}}

int dinhthuc(int k[][100] )
{
	
	int detA =(k[0][0]*k[1][1])-(k[0][1]*k[1][0]);
	while (detA<0){
		detA+=26; 
	} 
	

	return detA;
}
	
int Knghichdao(int n,int m){
	int count=m;
	int r,q; 
	int x,x0=0,x1=1;
	while(n>0)
	{
		r=m%n;
		if(r==0) break;
		else
		{
		q=m/n; 
		x=x0-x1*q;
		m=n;
		n=r;
		x0=x1;
		x1=x;
		}
	}
	if(n>1)
	cout<<"a khong co so nghich dao";
	else
	{
		if(x<0)
		{
			x+=count;
		}
		cout<<x;
		return x; 
	} 
} 


	
	
	
	
	

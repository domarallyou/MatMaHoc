#include <stdio.h>
#include <iostream>

using namespace std;
#include <string.h>
#include <conio.h>

void  xuat( char A[]);
void mahoa(char A[],int k[],int l,int z,char in[],char out[]);
void giaima(char A[],int k[],int l,int z,char in[],char out[]);
int gcd(int a, int b);
void  nhap(int A[]);
void  xuatmangint( int A[]);
int dongdu(int a);


int main()
{
	char A[26]={'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
	int k[2];
	int z=0;
	char in[100];
	char out[100]={'a'};
		cout<<"Moi ban nhap chuoi dau vao "; 
		fgets(in,100,stdin);
		int l=strlen(in);
	
	
	int a,b,c,d;
	cout<<"Moi ban nhap khoa K ";
	nhap(k);

	
	d=gcd(k[0],26);

	if(d==1)
		{
			cout<<"Chon 1 de Ma Hoa, 0 de Giai Ma ";
			cin>>a;
		if(a==1)
		{	
			mahoa(A,k,l,z,in,out);
			xuat(out);
		}
		else{
			giaima(A,k,l,z,in,out);	
			xuat(out);
		}	
	}
	else
	{
			cout<<"Ma K Khong Hop Le :";
	}  
    
}

void mahoa(char A[],int k[],int l,int z,char in[],char out[]){
		for (int i=0;i<l+1;i++){
		for (int j=0;j<26;j++){
		if(in[i]==A[j]){

			int m=(k[0]*j+k[1])%26;
			out[z]=A[m];
			z++;
		}
	}
	}
}

void giaima(char A[],int k[],int l,int z,char in[],char out[]){

		int S= dongdu(k[0]);
		for (int i=0;i<l+1;i++){
		for (int j=0;j<26;j++){
		
		if(in[i]==A[j]){
			int s=(j-k[1]);
			if(s<0)
			{
				s=s+26; 
			 } 
			 
			int m=(S*s % 26);
			
				out[z]=A[m];
			z++;
		}
		
	}

	}
}
void  xuat( char A[])
{
	for (int i=0;i<100;i++){
		cout<<A[i];		
	}
}
void  nhap( int A[])
{
	for (int i=0;i<2;i++){
		cin>>A[i];	
			
	}
}
void  xuatmangint( int A[])
{
	for (int i=0;i<2;i++){
		cout<<A[i]<<" ";		
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

int dongdu(int a){
	
	int j=0;
	 
		while(((a*j) % 26)!=1 )
		{
			 j++; 
			
		}
			return j; 
		 
	}


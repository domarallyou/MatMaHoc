#include <stdio.h>
#include <iostream>

using namespace std;
#include <string.h>
#include <conio.h>

void  xuat( char A[],int z);
void mahoa(char A[],int k,int l,int z,char in[],char out[]);
void giaima(char A[],int k,int l,int z,char in[],char out[]);


int main()
{
	char A[26]={'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
	int k;
	int z=0;
	char in[100];
	char out[100]={'a'};
		cout<<"Moi ban nhap chuoi dau vao"; 
		fgets(in,100,stdin);
		int l=strlen(in);
	
	int a;
	cout<<"Chon 1 de Ma Hoa, 0 de Giai Ma ";
	cin>>a;
	cout<<"Moi ban nhap khoa K ";
		cin>>k;
	if(a==1)
	{	
		mahoa(A,k,l,z,in,out);
		xuat(out,z);
		}
	else{
		giaima(A,k,l,z,in,out);	
		xuat(out,z);
		}
	

	

	

    
    
}

void mahoa(char A[],int k,int l,int z,char in[],char out[]){
			for (int i=0;i<l+1;i++){
		for (int j=0;j<26;j++){
		if(in[i]==A[j]){
			
			int m=(j+k)%26;
			out[z]=A[m];
			z++;
		}
	}
	}
}

void giaima(char A[],int k,int l,int z,char in[],char out[]){
			for (int i=0;i<l+1;i++){
		for (int j=0;j<26;j++){
		if(in[i]==A[j]){
			
			int m=(j-k)%26;
			out[z]=A[m];
			z++;
		}
		
	}
	}
}
void  xuat( char A[],int z)
{
	for (int i=0;i<26;i++){
		cout<<A[i];		
	}
}


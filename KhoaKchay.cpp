 #include <stdio.h>
#include <iostream>

using namespace std;
#include <string.h>
#include <conio.h>
#include <cstdlib>





void  xuat( char A[]);
void mahoa(char A[],int k[],int l,int z,char in[],char out[]);
void giaima(char A[],int k[],int l,int z,char in[],char out[]);
void changeK(int lengK,int l,char k[],char A[],char in[]);
void nhapkhoa(char A[]);
int * doiso(char k[],char A[]);
char* delete_space(char str[],char result[]);
void SainCyR(int table[][26]);
void  xuatmangint( int A[]);
int timvitri(char a,char A[]);
int Kgiaima(int a,int b,int table[][26],char A[]);
void  xuatmangint2( int A[][26]);





int main()
{
	
	int table[26][26];
	SainCyR(table);
	xuatmangint2(table);
	char A[26]={'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
	char k[100]={'a'};
	int z=0;
	char in[100];
	char out[100]={'a'};
	char IN[100]={'a'};
	int *K; 
	
		
		cout<<"Moi ban nhap chuoi dau vao "; 
		fgets(in,100,stdin);
		delete_space(in,IN);
		int l=strlen(IN);	
		nhapkhoa(k); 
		int lengK=strlen(k)-1;
		changeK(lengK,l,k,A,IN);
		K=doiso(k,A);
		char m=64;
		
		
	
		
	
	int a;
	cout<<"Chon 1 de Ma Hoa, 0 de Giai Ma ";
	cin>>a;
	
	
	if(a==1)
	{	
		mahoa(A,K,l,z,IN,out);
		xuat(out);
		}
	else{
		int j=0;
		int i=lengK;				 
		for( i;i<l;i++){			 
		K[i]=Kgiaima(timvitri(IN[j],A),K[j],table,A);
		j++;				
		}
		giaima(A,K,l,z,IN,out);	
		xuat(out);
		}   
}

int * doiso(char k[],char A[]){
	static int L[100];
	int e=0;
	for (int i=0;i<strlen(k);i++){
		for (int j=0;j<26;j++){
		if(k[i]==A[j]){
			L[e]=j;
			e++;
		}
	}}
	
	return L;	
}

void mahoa(char A[],int k[],int l,int z,char in[],char out[]){
		for (int i=0;i<l;i++){
		for (int j=0;j<26;j++){
		if(in[i]==A[j]){
			int m=(j+k[z]);
			if(m>25)
			{
				m=m-26;
			}
			out[z]=A[m];
			z++;
		}
	}
	}
}
void nhapkhoa(char A[]){
			cout<<"Moi ban nhap khoa K "; 
		fgets(A,100,stdin);
		
	
} 


void SainCyR(int table[][26]){
	int k=0;
	
		for (int i=0;i<26;i++){
		for(int j=0;j<26;j++)
		{
			
		
			table[i][j]=(k+j)%26;
			
		
		}
				k+=1;

	}
	
	
}

void changeK(int lengK,int l,char k[],char A[],char in[]){
		
	{
	int i=lengK;
	int j=0;
		
	for(i;i<l;i++){	
		k[i]=in[j];
		j++;
		}
	}		
		
}



int Kgiaima(int a,int b,int table[][26],char A[]){
	
	int i=0;	
		
	for( i;i<26;i++){	
		
		
			if(table[b][i]==a)
			{
				return i;
				}
			
		
	}	
		
		
}

void giaima(char A[],int k[],int l,int z,char in[],char out[]){
		for (int i=0;i<l;i++){
		for (int j=0;j<26;j++){
		if(in[i]==A[j]){
			int m=(j-k[z]);
			if(m<0)
			{
				m=m+26;
			}
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

void  xuatmangint( int A[])
{
	for (int i=0;i<26;i++){
		{
		cout<<A[i]<<"  ";		
		}
		
	}
}

int timvitri(char a,char A[])
{
for (int j=0;j<26;j++){		
		if(a==A[j]){
		return j;
}
}}

char* delete_space(char str[],char result[]) {
  int pos = 0;
 
  const int len = strlen(str);
  for(int i = 0; i < len; i++) {
      char chr = str[i];

      if (chr == '\r' || chr == '\n' || chr == ' ') {
        continue;
      }

  
      result[pos++] = chr;
  }
  return result;}

void  xuatmangint2( int A[][26])
{
	for (int i=0;i<26;i++){
			for(int j=0;j<26;j++)
		{
		cout<<A[i][j]<<"  ";		
		}
		cout<<"\n";
		
	}
}

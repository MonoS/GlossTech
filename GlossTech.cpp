#include <cstdlib>
#include <iostream>
#include <string.h>

using namespace std;

const int DIM_HEADER=128;
const int HEADER[DIM_HEADER]={68 ,68 ,83 ,32 ,124 ,0 ,0 ,0 ,15 ,16 ,0 ,0 ,8 ,0 ,0 ,0 ,8 ,0 ,0 ,0 ,24 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,32 ,0 ,0 ,0 ,64 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,24 ,0 ,0 ,0 ,0 ,0 ,255 ,0 ,0 ,255 ,0 ,0 ,255 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,16 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0};
const int HEAD_HEADER[DIM_HEADER]={68 ,68 ,83 ,32 ,124 ,0 ,0 ,0 ,15 ,16 ,0 ,0 ,0 ,8 ,0 ,0 ,0 ,8 ,0 ,0 ,0 ,32 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,32 ,0 ,0 ,0 ,65 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,32 ,0 ,0 ,0 ,255 ,0 ,0 ,0 ,0 ,255 ,0 ,0 ,0 ,0 ,255 ,0 ,0 ,0 ,0 ,255 ,0 ,16 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0};

int main()
{
    FILE* in_head;
    FILE* out_body;
    FILE* out_hands;
    FILE* out_head;
    int g, i, c;
    
    out_body=fopen("textures/actors/character/female/femalebody_1_s.dds", "w");
    out_hands=fopen("textures/actors/character/female/femalehands_1_s.dds", "w");
    in_head=fopen("head_base.bin", "r");
    out_head=fopen("TexBlend/Library/Head/Specular/femalehead_s.dds", "w");
    
    if((out_body!=NULL) && (out_hands!=NULL) && (out_head!=NULL) && (in_head!=NULL))
        {
        for(i=0; i<DIM_HEADER; i++)
        {
            fprintf(out_body, "%c", HEADER[i]);
            fprintf(out_hands, "%c", HEADER[i]);
            fprintf(out_head, "%c", HEAD_HEADER[i]);
        }
        
        do
        {
            cout<<"Chose the level of gloss <0/100>: ";
            cin>>g;
        }while ((g<0) || (g>100));
        
        g=g*255/100;
        
        for(i=0; i<=192; i++)
        {
            fprintf(out_body, "%c", g);
            fprintf(out_hands, "%c", g);
        }
        
        fclose(out_body); fclose(out_hands);
        
        fseek(in_head, 1078, SEEK_SET);
        
        do
        {
            c=fgetc(in_head);
            if(c!=EOF)
                if(c==0)
                    fprintf(out_head, "%c%c%c%c", g,g,g,255);
                else
                    fprintf(out_head, "%c%c%c%c", 0,0,0,0);
        }while(c!=EOF);
        
        fclose(in_head); fclose(out_head);
    }
    else
    {
        if(out_body==NULL)
            cout<<"Error during creation of femalebody_1_s.dds"<<endl;
        
        if(out_hands==NULL)
            cout<<"Error during creation of femalehands_1_s.dds"<<endl;
        
        if(out_head==NULL)
            cout<<"Error during creation of femalehead_s.dds"<<endl;
        
        if(in_head==NULL)
            cout<<"Error opening head_base.bmp! File not found"<<endl;
        
        system("pause");
    }
    
    return 0;
}

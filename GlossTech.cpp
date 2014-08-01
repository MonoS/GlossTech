/*  This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/


#include <cstdlib>
#include <iostream>
#include <windows.h>

using namespace std;

const int DIM_HEADER=128;
const int HEADER[DIM_HEADER]={68 ,68 ,83 ,32 ,124 ,0 ,0 ,0 ,15 ,16 ,0 ,0 ,8 ,0 ,0 ,0 ,8 ,0 ,0 ,0 ,24 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,32 ,0 ,0 ,0 ,64 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,24 ,0 ,0 ,0 ,0 ,0 ,255 ,0 ,0 ,255 ,0 ,0 ,255 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,16 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0};
const int HEAD_HEADER[DIM_HEADER]={68 ,68 ,83 ,32 ,124 ,0 ,0 ,0 ,15 ,16 ,0 ,0 ,0 ,8 ,0 ,0 ,0 ,8 ,0 ,0 ,0 ,32 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,32 ,0 ,0 ,0 ,65 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,32 ,0 ,0 ,0 ,0 ,0 ,255 ,0 ,0 ,255 ,0 ,0 ,255 ,0 ,0 ,0 ,0 ,0 ,0 ,255 ,0 ,16 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0};

int main()
{
    FILE* in_head;
    FILE* out_body;
    FILE* out_hands;
    FILE* out_head;
    int g, i, c;
    char chose;
    
    do
    {
        cout<<"Install or Uninstal mod <i/u>? ";
        cin>>chose;
    }while((chose!='i') && (chose!='u'));
    
    if(chose=='i')
    {
        in_head=fopen("head_base.bin", "r");
        out_head=fopen("TexBlend/Library/Head/Specular/femalehead_s.dds", "w");
        
        if((out_head!=NULL) && (in_head!=NULL))
        {
            //ask some settings
            do
            {
                cout<<"Do you use a custom race <y/n>? ";
                cin>>chose;
            }while((chose!='y') && (chose!='n'));
            
            
            if(chose=='n')
            {
                do
                {
                    cout<<"Do you want to create a backup <y/n>? ";
                    cin>>chose;
                }while((chose!='y') && (chose!='n'));
                
                if(chose=='y')
                {
                    if(CopyFile("textures/actors/character/female/femalebody_1_s.dds", "textures/actors/character/female/femalebody_1_s.dds.gloss",true))
                        cout<<"Backup created whit this name: femalebody_1_s.dds.gloss"<<endl;
                    else
                        cout<<"Cannot create backup of femalebody_1_s.dds"<<endl;
                    
                    if(CopyFile("textures/actors/character/female/femalehands_1_s.dds", "textures/actors/character/female/femalehands_1_s.dds.gloss",true))
                        cout<<"Backup created whit this name: femalehands_1_s.gloss"<<endl;
                    else
                        cout<<"Cannot create backup of femalehands_1_s.dds"<<endl;
                    
                    if(CopyFile("textures/actors/character/female/femalehead_s.dds", "textures/actors/character/female/femalehead_s.dds.gloss",true))
                        cout<<"Backup created whit this name: femalehead_s.dds.gloss"<<endl;
                    else
                        cout<<"Cannot create backup of femalehead_s.dds"<<endl;
                }
                
                out_body=fopen("textures/actors/character/female/femalebody_1_s.dds", "w");
                out_hands=fopen("textures/actors/character/female/femalehands_1_s.dds", "w");
            }
            else
            {
                out_body=fopen("customrace/femalebody_1_s.dds", "w");
                out_hands=fopen("customrace/femalehands_1_s.dds", "w");
            }
            
            if((out_body!=NULL) && (out_hands!=NULL))
            {
                do
                {
                    cout<<"Chose the level of gloss <0/100>: ";
                    cin>>g;
                }while ((g<0) || (g>100));
                
                
                //writing the header into the file
                for(i=0; i<DIM_HEADER; i++)
                {
                    fprintf(out_body, "%c", HEADER[i]);
                    fprintf(out_hands, "%c", HEADER[i]);
                    fprintf(out_head, "%c", HEAD_HEADER[i]);
                }
                
                g=g*255/100; //calulate the grey
                
                //writing the body and hands files
                for(i=0; i<=192; i++)
                {
                    fprintf(out_body, "%c", g);
                    fprintf(out_hands, "%c", g);
                }
                
                fclose(out_body); fclose(out_hands);
                
                fseek(in_head, 1078, SEEK_SET); //jumping the header of head_base file
                
                //writing the head file following the head_base mesh
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
                
                cout<<"All done!!"<<endl;
            }
            else
            {
                //errors branch
                if(out_body==NULL)
                    cout<<"Error during creation of femalebody_1_s.dds"<<endl;
                
                if(out_hands==NULL)
                    cout<<"Error during creation of femalehands_1_s.dds"<<endl;
            }
        }
        else
        {
            //errors branch
            if(out_head==NULL)
                cout<<"Error during creation of femalehead_s.dds"<<endl;
            
            if(in_head==NULL)
                cout<<"Error opening head_base.bmp! File not found"<<endl;
            
        }
    }
    else
    {
        if(CopyFile("textures/actors/character/female/femalebody_1_s.dds.gloss", "textures/actors/character/female/femalebody_1_s.dds",false))
            cout<<"Backup restored successfully"<<endl;
        else
            cout<<"backup file not found for femalebody_1_s.dds"<<endl;
        
        remove("textures/actors/character/female/femalebody_1_s.dds.gloss");
        
        if(CopyFile("textures/actors/character/female/femalehands_1_s.dds.gloss", "textures/actors/character/female/femalehands_1_s.dds",false))
            cout<<"Backup restored successfully"<<endl;
        else
            cout<<"backup file not found for femalehands_1_s.dds"<<endl;
        
        remove("textures/actors/character/female/femalehands_1_s.dds.gloss");
        
        if(CopyFile("textures/actors/character/female/femalehead_s.dds.gloss", "textures/actors/character/female/femalehead_s.dds",false))
            cout<<"Backup restored successfully"<<endl;
        else
            cout<<"backup file not found for femalehead_s.dds"<<endl;
        
        remove("textures/actors/character/female/femalehead_s.dds.gloss");
    }
    
    system("pause");
    return 0;
}


//Some cool stuff for the next version :3
            /*do
            {
                c=fgetc(in_head);//read the first colour
                fgetc(in_head); fgetc(in_head); //jump the other two colour
                
                if(c!=EOF)
                {
                    if(c<255)
                        fprintf(out_head, "%c%c%c%c", g,g,g,(255-c));//print the gloss and trasparency
                    else
                        fprintf(out_head, "%c%c%c%c", 0,0,0,0);//print only trasparency
                }
            }while(c!=EOF);*/

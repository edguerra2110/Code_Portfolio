// name:        Edgar Guerra
// date:        9/3/2021
// file name:   parse-csv.c
// course:      ETSU - CSCI 4727-001: Operating Systems
// description: program that takes in a .CSV file name to read then stores the records in a struct array
//              then writes the record out to the .txt file.
#include <stdio.h>
#include <stdlib.h>
#include "product_record.h"
#include <assert.h>

int main(int argc, char *argv[]){
    //if not the correct amount of parameters printf a message and exit with error code 1
    if(argc != 3){
        printf("Please input a file to read and a file to write to\nparse-csv [readFile] [writeFile]");
        exit(1);
    }
    //create and instantiate FILE objects and open them
    FILE *rFile_ptr, *wFile_ptr;
    //if file doesn't exist then exit else continue
    ((rFile_ptr = fopen(argv[1],"r")) == NULL) ? exit(404) : rFile_ptr;
    wFile_ptr = fopen(argv[2],"w");
    char line[1024];

    struct product_record productRecord = {};
    while (fgets(line,sizeof (line),rFile_ptr)) {
        sscanf(line,"%i, %[^,], %lf, %i, %lf, %lf, %lf, %i %i %i %i %i"
                ,&productRecord.idnumber
                ,productRecord.name
                ,&productRecord.price
                ,&productRecord.number
                ,&productRecord.tax
                ,&productRecord.sANDh
                ,&productRecord.total
                ,&productRecord.stations[0], &productRecord.stations[1],&productRecord.stations[2],&productRecord.stations[3],&productRecord.stations[4]);
        fprintf(wFile_ptr,"%i, %s, %lf, %i, %lf, %lf, %lf, %i %i %i %i %i\n"
                ,productRecord.idnumber
                ,productRecord.name
                ,productRecord.price
                ,productRecord.number
                ,productRecord.tax
                ,productRecord.sANDh
                ,productRecord.total
                ,productRecord.stations[0], productRecord.stations[1],productRecord.stations[2],productRecord.stations[3],productRecord.stations[4]);

        printf("%i, %s, %lf, %i, %lf, %lf, %lf, %i %i %i %i %i\n"
                ,productRecord.idnumber
                ,productRecord.name
                ,productRecord.price
                ,productRecord.number
                ,productRecord.tax
                ,productRecord.sANDh
                ,productRecord.total
                ,productRecord.stations[0], productRecord.stations[1],productRecord.stations[2],productRecord.stations[3],productRecord.stations[4]);
    }
    //close files
    fclose(rFile_ptr);
    fclose(wFile_ptr);

    return 0;
}

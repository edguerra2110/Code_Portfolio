CREATE TABLE BICYCLE(
    SERIALNUMBER INT,
    CUSTOMERID INT DEFAULT 0,
    MODELTYPE VARCHAR(50),
    PAINTID INT DEFAULT 0,
    FRAMESIZE NUMERIC DEFAULT 0,
    ORDERDATE DATETIME,
    STARTDATE DATETIME,
    SHIPDATE DATETIME,
    SHIPEMPLOYEE INT DEFAULT 0,
    FRAMEASSEMBLER INT DEFAULT 0,
    PAINTER INT DEFAULT 0,
    CONSTRUCTION VARCHAR(50 ) DEFAULT 'Bonded',
    WATERBOTTLEBRAZEONS INT DEFAULT 4,
    CUSTOMNAME VARCHAR(50 ),
    LETTERSTYLEID VARCHAR(50),
    STOREID INT DEFAULT 0,
    EMPLOYEEID INT DEFAULT 0,
    TOPTUBE NUMERIC DEFAULT 0,
    CHAINSTAY NUMERIC DEFAULT 0,
    HEADTUBEANGLE NUMERIC DEFAULT 0,
    SEATTUBEANGLE NUMERIC DEFAULT 0,
    LISTPRICE NUMERIC(38, 4) DEFAULT 0,
    SALEPRICE NUMERIC(38, 4) DEFAULT 0,
    SALESTAX NUMERIC(38, 4) DEFAULT 0,
    SALESTATE VARCHAR(50),
    SHIPPRICE NUMERIC(38, 4) DEFAULT 0,
    FRAMEPRICE NUMERIC(38, 4) DEFAULT 0,
    COMPONENTLIST NUMERIC(38, 4) DEFAULT 0
); 
--  DDL for Table BICYCLETUBEUSAGE--

CREATE TABLE BICYCLETUBEUSAGE(
    SERIALNUMBER INT DEFAULT 0,
    TUBEID INT DEFAULT 0,
    QUANTITY NUMERIC DEFAULT 0
) ; 
--  DDL for Table BIKEPARTS --

CREATE TABLE BIKEPARTS(
    SERIALNUMBER INT DEFAULT 0,
    COMPONENTID INT DEFAULT 0,
    SUBSTITUTEID INT DEFAULT 0,
    LOCATION VARCHAR(50),
    QUANTITY INT DEFAULT 0,
    DATEINSTALLED DATETIME,
    EMPLOYEEID INT DEFAULT 0
); 
--  DDL for Table BIKETUBES --

CREATE TABLE BIKETUBES(
    SERIALNUMBER INT DEFAULT 0,
    TUBENAME VARCHAR(50),
    TUBEID INT DEFAULT 0,
    LENGTH NUMERIC DEFAULT 0
) ;
--  DDL for Table CITY--

CREATE TABLE CITY(
    CITYID INT,
    ZIPCODE VARCHAR(50 ),
    CITY VARCHAR(50 ),
    STATE VARCHAR(50 ),
    AREACODE VARCHAR(50 ),
    POPULATION1990 INT DEFAULT 0,
    POPULATION1980 INT DEFAULT 0,
    COUNTRY VARCHAR(50),
    LATITUDE NUMERIC DEFAULT 0,
    LONGITUDE NUMERIC DEFAULT 0,
    POPULATIONCDF NUMERIC DEFAULT 0
) ;
--  DDL for Table COMMONSIZES --

CREATE TABLE COMMONSIZES(
    MODELTYPE VARCHAR(50 ),
    FRAMESIZE NUMERIC DEFAULT 0
) ;
--  DDL for Table COMPONENT--

CREATE TABLE COMPONENT(
    COMPONENTID INT DEFAULT 0,
    MANUFACTURERID INT DEFAULT 0,
    PRODUCTNUMBER VARCHAR(50),
    ROAD VARCHAR(50 ),
    CATEGORY VARCHAR(50 ),
    LENGTH NUMERIC DEFAULT 0,
    HEIGHT NUMERIC DEFAULT 0,
    WIDTH NUMERIC DEFAULT 0,
    WEIGHT NUMERIC DEFAULT 0,
    YEAR INT,
    ENDYEAR INT,
    DESCRIPTION VARCHAR(100 ),
    LISTPRICE NUMERIC(38, 4) DEFAULT 0,
    ESTIMATEDCOST NUMERIC(38, 4) DEFAULT 0,
    QUANTITYONHAND NUMERIC DEFAULT 10
) ;
--  DDL for Table COMPONENTNAME--

CREATE TABLE COMPONENTNAME(
    COMPONENTNAME VARCHAR(50),
    ASSEMBLYORDER INT DEFAULT 0,
    DESCRIPTION VARCHAR(50 )
) ;
--  DDL for Table CUSTOMER --

CREATE TABLE CUSTOMER(
    CUSTOMERID INT,
    PHONE VARCHAR(50),
    FIRSTNAME VARCHAR(50),
    LASTNAME VARCHAR(50),
    ADDRESS VARCHAR(50),
    ZIPCODE VARCHAR(50),
    CITYID INT DEFAULT 0,
    BALANCEDUE NUMERIC(38, 4) DEFAULT 0
) ;
--  DDL for Table CUSTOMERTRANSACTION --

CREATE TABLE CUSTOMERTRANSACTION(
    CUSTOMERID INT DEFAULT 0,
    TRANSACTIONDATE DATETIME,
    EMPLOYEEID INT DEFAULT 0,
    AMOUNT NUMERIC(38, 4) DEFAULT 0,
    DESCRIPTION VARCHAR(250 ),
    REFERENCE INT DEFAULT 0
) ;
--  DDL for Table EMPLOYEE--

CREATE TABLE EMPLOYEE(
    EMPLOYEEID INT DEFAULT 0,
    TAXPAYERID VARCHAR(50 ),
    LASTNAME VARCHAR(50 ),
    FIRSTNAME VARCHAR(50 ),
    HOMEPHONE VARCHAR(50 ),
    ADDRESS VARCHAR(50 ),
    ZIPCODE VARCHAR(50 ),
    CITYID INT DEFAULT 0,
    DATEHIRED DATETIME,
    DATERELEASED DATETIME,
    CURRENTMANAGER INT DEFAULT 0,
    SALARYGRADE INT DEFAULT 0,
    SALARY NUMERIC(38, 4) DEFAULT 0,
    TITLE VARCHAR(100 ),
    WORKAREA VARCHAR(50 )
) ;
--  DDL for Table GROUPCOMPONENTS --

CREATE TABLE GROUPCOMPONENTS(
    GROUPID INT DEFAULT 0,
    COMPONENTID INT DEFAULT 0
) ;
--  DDL for Table GROUPO --

CREATE TABLE GROUPO(
    COMPONENTGROUPID INT,
    GROUPNAME VARCHAR(50 ),
    BIKETYPE VARCHAR(50 ),
    YEAR INT,
    ENDYEAR NUMERIC,
    WEIGHT NUMERIC(15, 4)
) ;
--  DDL for Table LETTERSTYLE --

CREATE TABLE LETTERSTYLE(
    LETTERSTYLE VARCHAR(50 ),
    DESCRIPTION VARCHAR(50 )
) ;
--  DDL for Table MANUFACTURER
 --

CREATE TABLE MANUFACTURER(
    MANUFACTURERID INT,
    MANUFACTURERNAME VARCHAR(50 ),
    CONTACTNAME VARCHAR(50 ),
    PHONE VARCHAR(50 ),
    ADDRESS VARCHAR(50 ),
    ZIPCODE VARCHAR(50),
    CITYID INT DEFAULT 0,
    BALANCEDUE NUMERIC(38, 4) DEFAULT 0
) ;
 --

--  DDL for Table MANUFACTURERTRANSACTION
 --

CREATE TABLE MANUFACTURERTRANSACTION(
    MANUFACTURERID INT DEFAULT 0,
    TRANSACTIONDATE DATETIME,
    EMPLOYEEID INT DEFAULT 0,
    AMOUNT NUMERIC(38, 4) DEFAULT 0,
    DESCRIPTION VARCHAR(250 ),
    REFERENCE INT DEFAULT 0
) ;

 --
--  DDL for Table MODELSIZE
 --

CREATE TABLE MODELSIZE(
    MODELTYPE VARCHAR(50 ),
    MSIZE NUMERIC DEFAULT 0,
    TOPTUBE NUMERIC DEFAULT 0,
    CHAINSTAY NUMERIC DEFAULT 0,
    TOTALLENGTH NUMERIC DEFAULT 0,
    GROUNDCLEARANCE NUMERIC DEFAULT 0,
    HEADTUBEANGLE NUMERIC DEFAULT 0,
    SEATTUBEANGLE NUMERIC DEFAULT 0
) ;
 --

--  DDL for Table MODELTYPE
 --

CREATE TABLE MODELTYPE(
    MODELTYPE VARCHAR(50 ),
    DESCRIPTION VARCHAR(50 ),
    COMPONENTID INT
) ;
 --

--  DDL for Table PAINT
 --

CREATE TABLE PAINT(
    PAINTID INT,
    COLORNAME VARCHAR(50 ),
    COLORSTYLE VARCHAR(50 ) DEFAULT 'Solid',
    COLORLIST VARCHAR(50 ),
    DATEINTRODUCED DATETIME,
    DATEDISCONTINUED DATETIME
) ;
 --

--  DDL for Table PREFERENCE
 --

CREATE TABLE PREFERENCE(
    ITEMNAME VARCHAR(50 ),
    VALUE NUMERIC DEFAULT 0,
    DESCRIPTION VARCHAR(250 ),
    DATECHANGED DATETIME
) ;
 --

--  DDL for Table PURCHASEITEM
 --

CREATE TABLE PURCHASEITEM(
    PURCHASEID INT DEFAULT 0,
    COMPONENTID INT DEFAULT 0,
    PRICEPAID NUMERIC(38, 4) DEFAULT 0,
    QUANTITY INT DEFAULT 0,
    QUANTITYRECEIVED INT DEFAULT 0
) ;
 --
--  DDL for Table PURCHASEORDER
 --

CREATE TABLE PURCHASEORDER(
    PURCHASEID INT,
    EMPLOYEEID INT DEFAULT 0,
    MANUFACTURERID INT DEFAULT 0,
    TOTALLIST NUMERIC(38, 4) DEFAULT 0,
    SHIPPINGCOST NUMERIC(38, 4) DEFAULT 0,
    DISCOUNT NUMERIC(38, 4) DEFAULT 0,
    ORDERDATE DATETIME,
    RECEIVEDATE DATETIME,
    AMOUNTDUE NUMERIC(38, 4) DEFAULT 0
) ;

 --
--  DDL for Table RETAILSTORE
 --

CREATE TABLE RETAILSTORE(
    STOREID INT,
    STORENAME VARCHAR(50 ),
    PHONE VARCHAR(50 ),
    CONTACTFIRSTNAME VARCHAR(50 ),
    CONTACTLASTNAME VARCHAR(50 ),
    ADDRESS VARCHAR(50 ),
    ZIPCODE VARCHAR(50 ),
    CITYID INT DEFAULT 0
) ;

 --
--  DDL for Table REVISIONHISTORY
 --

CREATE TABLE REVISIONHISTORY(
    ID INT,
    VERSION VARCHAR(50 ),
    CHANGEDATE DATETIME,
    NAME VARCHAR(50 ),
    REVISIONCOMMENTS VARCHAR(250 )
) ;
 --
--  DDL for Table SAMPLENAME
 --

CREATE TABLE SAMPLENAME(
    ID INT,
    LASTNAME VARCHAR(50 ),
    FIRSTNAME VARCHAR(50 ),
    GENDER VARCHAR(50 )
) ;
 --
--  DDL for Table SAMPLESTREET
 --

CREATE TABLE SAMPLESTREET(
    ID INT,
    BASEADDRESS VARCHAR(50 )
) ;
 --
--  DDL for Table STATETAXRATE
 --

CREATE TABLE STATETAXRATE(
    STATE VARCHAR(50 ),
    TAXRATE NUMERIC DEFAULT 0
) ;

 --
--  DDL for Table TEMPDATEMADE
 --

CREATE TABLE TEMPDATEMADE(
    DATEVALUE DATETIME,
    MADECOUNT NUMERIC DEFAULT 0
) ;
--  DDL for Table TUBEMATERIAL
 --

CREATE TABLE TUBEMATERIAL(
    TUBEID INT DEFAULT 0,
    MATERIAL VARCHAR(50 ),
    DESCRIPTION VARCHAR(100 ),
    DIAMETER NUMERIC DEFAULT 0,
    THICKNESS NUMERIC DEFAULT 0,
    ROUNDNESS VARCHAR(50 ),
    WEIGHT NUMERIC DEFAULT 0,
    STIFFNESS NUMERIC DEFAULT 0,
    LISTPRICE NUMERIC(38, 4) DEFAULT 1,
    CONSTRUCTION VARCHAR(50 ) DEFAULT 'Bonded'
) ;
 --

--  DDL for Table WORKAREA
 --

CREATE TABLE WORKAREA(
    WORKAREA VARCHAR(50 ),
    DESCRIPTION VARCHAR(50 )
);  --

--  DDL for Index PK_BICYCLE
 --

CREATE UNIQUE INDEX PK_BICYCLE ON
    BICYCLE(SERIALNUMBER) ;  --

    --  DDL for Index PK_BICYCLETUBEUSAGE
     --

CREATE UNIQUE INDEX PK_BICYCLETUBEUSAGE ON
    BICYCLETUBEUSAGE(SERIALNUMBER, TUBEID); 
     --

    --  DDL for Index PK_BIKEPARTS
     --

CREATE UNIQUE INDEX PK_BIKEPARTS ON
    BIKEPARTS(SERIALNUMBER, COMPONENTID); 
     --
    --  DDL for Index PK_BIKETUBES
     --

CREATE UNIQUE INDEX PK_BIKETUBES ON
    BIKETUBES(SERIALNUMBER, TUBENAME);
     --
    --  DDL for Index PK_CITY
     --

CREATE UNIQUE INDEX PK_CITY ON
    CITY(CITYID); 
     --

    --  DDL for Index PK_COMMONSIZES
     --

CREATE UNIQUE INDEX PK_COMMONSIZES ON
    COMMONSIZES(MODELTYPE, FRAMESIZE) ;
     --
    --  DDL for Index PK_COMPONENT
     --

CREATE UNIQUE INDEX PK_COMPONENT ON
    COMPONENT(COMPONENTID) ;
     --

    --  DDL for Index PK_COMPONENTNAME
     --

CREATE UNIQUE INDEX PK_COMPONENTNAME ON
    COMPONENTNAME(COMPONENTNAME);  
     --

    --  DDL for Index PK_CUSTOMER
     --

CREATE UNIQUE INDEX PK_CUSTOMER ON
    CUSTOMER(CUSTOMERID)  ;
     --

    --  DDL for Index PK_CUSTOMERTRANSACTION
     --

CREATE UNIQUE INDEX PK_CUSTOMERTRANSACTION ON
    CUSTOMERTRANSACTION(CUSTOMERID, TRANSACTIONDATE); 
     --
    --  DDL for Index PK_EMPLOYEE
     --

CREATE UNIQUE INDEX PK_EMPLOYEE ON
    EMPLOYEE(EMPLOYEEID);
     --
    --  DDL for Index PK_GROUPCOMPONENTS
     --

CREATE UNIQUE INDEX PK_GROUPCOMPONENTS ON
    GROUPCOMPONENTS(GROUPID, COMPONENTID); 
     --
    --  DDL for Index PK_GROUPO
     --

CREATE UNIQUE INDEX PK_GROUPO ON
    GROUPO(COMPONENTGROUPID);  --

    --  DDL for Index PK_LETTERSTYLE
     --

CREATE UNIQUE INDEX PK_LETTERSTYLE ON
    LETTERSTYLE(LETTERSTYLE);  
     --

    --  DDL for Index PK_MANUFACTURER
     --

CREATE UNIQUE INDEX PK_MANUFACTURER ON
    MANUFACTURER(MANUFACTURERID);  --

    --  DDL for Index PK_MANUFTRANSACTION
     --

CREATE UNIQUE INDEX PK_MANUFTRANSACTION ON
    MANUFACTURERTRANSACTION(
        MANUFACTURERID,
        TRANSACTIONDATE,
        REFERENCE
    );   --

    --  DDL for Index PK_MODELSIZE
     --

CREATE UNIQUE INDEX PK_MODELSIZE ON
    MODELSIZE(MODELTYPE, MSIZE);  --

    --  DDL for Index PK_MODELTYPE
     --

CREATE UNIQUE INDEX PK_MODELTYPE ON
    MODELTYPE(MODELTYPE);   --

    --  DDL for Index PK_PAINT
     --

CREATE UNIQUE INDEX PK_PAINT ON
    PAINT(PAINTID);   --

    --  DDL for Index PK_PREFERENCE
     --

CREATE UNIQUE INDEX PK_PREFERENCE ON
    PREFERENCE(ITEMNAME);   --

    --  DDL for Index PK_PURCHASEITEM
     --

CREATE UNIQUE INDEX PK_PURCHASEITEM ON
    PURCHASEITEM(PURCHASEID, COMPONENTID);   --

    --  DDL for Index PK_PURCHASEORDER
     --

CREATE UNIQUE INDEX PK_PURCHASEORDER ON
    PURCHASEORDER(PURCHASEID);   --

    --  DDL for Index PK_RETAILSTORE
     --

CREATE UNIQUE INDEX PK_RETAILSTORE ON
    RETAILSTORE(STOREID);   --

    --  DDL for Index PK_REVISIONHISTORY
     --

CREATE UNIQUE INDEX PK_REVISIONHISTORY ON
    REVISIONHISTORY(ID);   --

    --  DDL for Index PK_SAMPLENAME
     --

CREATE UNIQUE INDEX PK_SAMPLENAME ON
    SAMPLENAME(ID);   --

    --  DDL for Index PK_SAMPLESTREET
     --

CREATE UNIQUE INDEX PK_SAMPLESTREET ON
    SAMPLESTREET(ID);   --

    --  DDL for Index PK_STATETAXRATE
     --

CREATE UNIQUE INDEX PK_STATETAXRATE ON
    STATETAXRATE(STATE);   --

    --  DDL for Index PK_TEMPDATEMADE
     --

CREATE UNIQUE INDEX PK_TEMPDATEMADE ON
    TEMPDATEMADE(DATEVALUE);  
     --

    --  DDL for Index PK_TUBEMATERIAL
     --

CREATE UNIQUE INDEX PK_TUBEMATERIAL ON
    TUBEMATERIAL(TUBEID);   --

    --  DDL for Index PK_WORKAREA
     --

CREATE UNIQUE INDEX PK_WORKAREA ON
    WORKAREA(WORKAREA);   --

    --  Constraints for Table BICYCLE
     --

ALTER TABLE
    BICYCLE ADD CONSTRAINT PK_BICYCLE PRIMARY KEY(SERIALNUMBER);
     --

    --  Constraints for Table BICYCLETUBEUSAGE
     --

ALTER TABLE
    BICYCLETUBEUSAGE ADD CONSTRAINT PK_BICYCLETUBEUSAGE PRIMARY KEY(SERIALNUMBER, TUBEID); 
          --

    --  Constraints for Table BIKEPARTS
     --

ALTER TABLE
    BIKEPARTS ADD CONSTRAINT PK_BIKEPARTS PRIMARY KEY(SERIALNUMBER, COMPONENTID);
     --

    --  Constraints for Table BIKETUBES
     --

ALTER TABLE
    BIKETUBES ADD
CHECK
    (
        TubeName IN(
            'Top',
            'Seat',
            'Rear',
            'Chain',
            'Down',
            'Front'
        )
    ) ;
ALTER TABLE
    BIKETUBES ADD CONSTRAINT PK_BIKETUBES PRIMARY KEY(SERIALNUMBER, TUBENAME) ;   --

    --  Constraints for Table CITY
     --

ALTER TABLE
    CITY ADD CONSTRAINT PK_CITY PRIMARY KEY(CITYID) ;
     --

    --  Constraints for Table COMMONSIZES
     --

ALTER TABLE
    COMMONSIZES ADD CONSTRAINT PK_COMMONSIZES PRIMARY KEY(MODELTYPE, FRAMESIZE);   --

    --  Constraints for Table COMPONENT
     --

ALTER TABLE
    COMPONENT ADD CONSTRAINT PK_COMPONENT PRIMARY KEY(COMPONENTID);   --

    --  Constraints for Table COMPONENTNAME
     --

ALTER TABLE
    COMPONENTNAME ADD CONSTRAINT PK_COMPONENTNAME PRIMARY KEY(COMPONENTNAME);   --

    --  Constraints for Table CUSTOMER
     --

ALTER TABLE
    CUSTOMER ADD CONSTRAINT PK_CUSTOMER PRIMARY KEY(CUSTOMERID); 
     --

    --  Constraints for Table CUSTOMERTRANSACTION
     --

ALTER TABLE
    CUSTOMERTRANSACTION ADD CONSTRAINT PK_CUSTOMERTRANSACTION PRIMARY KEY(CUSTOMERID,TRANSACTIONDATE);   --

    --  Constraints for Table EMPLOYEE
     --

ALTER TABLE
    EMPLOYEE ADD CONSTRAINT PK_EMPLOYEE PRIMARY KEY(EMPLOYEEID);   --

    --  Constraints for Table GROUPCOMPONENTS
     --

ALTER TABLE
    GROUPCOMPONENTS ADD CONSTRAINT PK_GROUPCOMPONENTS PRIMARY KEY(GROUPID, COMPONENTID) ;   --

    --  Constraints for Table GROUPO
     --

ALTER TABLE
    GROUPO ADD CONSTRAINT PK_GROUPO PRIMARY KEY(COMPONENTGROUPID) ;   --

    --  Constraints for Table LETTERSTYLE
     --

ALTER TABLE
    LETTERSTYLE ADD CONSTRAINT PK_LETTERSTYLE PRIMARY KEY(LETTERSTYLE);   --

    --  Constraints for Table MANUFACTURER
     --

ALTER TABLE
    MANUFACTURER ADD CONSTRAINT PK_MANUFACTURER PRIMARY KEY(MANUFACTURERID) ;   --

    --  Constraints for Table MANUFACTURERTRANSACTION
     --

ALTER TABLE
    MANUFACTURERTRANSACTION ADD CONSTRAINT PK_MANUFTRANSACTION PRIMARY KEY(
        MANUFACTURERID,
        TRANSACTIONDATE,
        REFERENCE
    ) ;   --

    --  Constraints for Table MODELSIZE
     --

ALTER TABLE
    MODELSIZE ADD CONSTRAINT PK_MODELSIZE PRIMARY KEY(MODELTYPE, MSIZE) ;   --

    --  Constraints for Table MODELTYPE
     --

ALTER TABLE
    MODELTYPE ADD CONSTRAINT PK_MODELTYPE PRIMARY KEY(MODELTYPE);   --

    --  Constraints for Table PAINT
     --

ALTER TABLE
    PAINT ADD
CHECK
    (
        ColorStyle IN(
            'Solid',
            'Two Color',
            'Three Color',
            'Special'
        )
    ) ;
ALTER TABLE
    PAINT ADD CONSTRAINT PK_PAINT PRIMARY KEY(PAINTID) ;   --

    --  Constraints for Table PREFERENCE
     --

ALTER TABLE
    PREFERENCE ADD CONSTRAINT PK_PREFERENCE PRIMARY KEY(ITEMNAME) ;   --

    --  Constraints for Table PURCHASEITEM
     --

ALTER TABLE
    PURCHASEITEM ADD CONSTRAINT PK_PURCHASEITEM PRIMARY KEY(PURCHASEID, COMPONENTID);  
     --
    --  Constraints for Table PURCHASEORDER
     --

ALTER TABLE
    PURCHASEORDER ADD CONSTRAINT PK_PURCHASEORDER PRIMARY KEY(PURCHASEID) ;
     --
    --  Constraints for Table RETAILSTORE
     --

ALTER TABLE
    RETAILSTORE ADD CONSTRAINT PK_RETAILSTORE PRIMARY KEY(STOREID) ;  --

    --  Constraints for Table REVISIONHISTORY
     --

ALTER TABLE
    REVISIONHISTORY ADD CONSTRAINT PK_REVISIONHISTORY PRIMARY KEY(ID) ;  --

    --  Constraints for Table SAMPLENAME
     --

ALTER TABLE
    SAMPLENAME ADD
CHECK
    (Gender IN('M', 'F')) ;
ALTER TABLE
    SAMPLENAME ADD CONSTRAINT PK_SAMPLENAME PRIMARY KEY(ID) ;   --

    --  Constraints for Table SAMPLESTREET
     --

ALTER TABLE
    SAMPLESTREET ADD CONSTRAINT PK_SAMPLESTREET PRIMARY KEY(ID) ;   --

    --  Constraints for Table STATETAXRATE
     --

ALTER TABLE
    STATETAXRATE ADD CONSTRAINT PK_STATETAXRATE PRIMARY KEY(STATE) ;   --

    --  Constraints for Table TEMPDATEMADE
     --

ALTER TABLE
    TEMPDATEMADE ADD CONSTRAINT PK_TEMPDATEMADE PRIMARY KEY(DATEVALUE) ;
     --

    --  Constraints for Table TUBEMATERIAL
     --

ALTER TABLE
    TUBEMATERIAL ADD CONSTRAINT PK_TUBEMATERIAL PRIMARY KEY(TUBEID) ;
     --

    --  Constraints for Table WORKAREA
     --

ALTER TABLE
    WORKAREA ADD CONSTRAINT PK_WORKAREA PRIMARY KEY(WORKAREA) ;   --

    --  Ref Constraints for Table BICYCLE
     --

ALTER TABLE
    BICYCLE ADD CONSTRAINT FK_BIKEMODELTYPE FOREIGN KEY(MODELTYPE) REFERENCES MODELTYPE(MODELTYPE) ON DELETE CASCADE ;
ALTER TABLE
    BICYCLE ADD CONSTRAINT FK_BIKEEMPLOYEE FOREIGN KEY(EMPLOYEEID) REFERENCES EMPLOYEE(EMPLOYEEID) ON DELETE CASCADE ;
ALTER TABLE
    BICYCLE ADD CONSTRAINT FK_BIKERETAIL FOREIGN KEY(STOREID) REFERENCES RETAILSTORE(STOREID) ON DELETE CASCADE ;
ALTER TABLE
    BICYCLE ADD CONSTRAINT FK_BIKECUSTOMER FOREIGN KEY(CUSTOMERID) REFERENCES CUSTOMER(CUSTOMERID) ON DELETE CASCADE ;
ALTER TABLE
    BICYCLE ADD CONSTRAINT FK_BIKELETTER FOREIGN KEY(LETTERSTYLEID) REFERENCES LETTERSTYLE(LETTERSTYLE) ON DELETE CASCADE ;
ALTER TABLE
    BICYCLE ADD CONSTRAINT FK_BIKEPAINT FOREIGN KEY(PAINTID) REFERENCES PAINT(PAINTID) ON DELETE CASCADE ;  --

    --  Ref Constraints for Table BICYCLETUBEUSAGE
     --

ALTER TABLE
    BICYCLETUBEUSAGE ADD CONSTRAINT FK_REFERENCE26 FOREIGN KEY(SERIALNUMBER) REFERENCES BICYCLE(SERIALNUMBER) ON DELETE CASCADE ;
ALTER TABLE
    BICYCLETUBEUSAGE ADD CONSTRAINT FK_REFERENCE27 FOREIGN KEY(TUBEID) REFERENCES TUBEMATERIAL(TUBEID) ON DELETE CASCADE ;  --

    --  Ref Constraints for Table BIKEPARTS
     --

ALTER TABLE
    BIKEPARTS ADD CONSTRAINT FK_REFERENCE24 FOREIGN KEY(SERIALNUMBER) REFERENCES BICYCLE(SERIALNUMBER) ON DELETE CASCADE ;
ALTER TABLE
    BIKEPARTS ADD CONSTRAINT FK_REFERENCE4 FOREIGN KEY(EMPLOYEEID) REFERENCES EMPLOYEE(EMPLOYEEID) ON DELETE CASCADE ;
ALTER TABLE
    BIKEPARTS ADD CONSTRAINT FK_REFERENCE5 FOREIGN KEY(COMPONENTID) REFERENCES COMPONENT(COMPONENTID) ON DELETE CASCADE ;  --

    --  Ref Constraints for Table BIKETUBES
     --

ALTER TABLE
    BIKETUBES ADD CONSTRAINT FK_REFERENCE6 FOREIGN KEY(SERIALNUMBER) REFERENCES BICYCLE(SERIALNUMBER) ON DELETE CASCADE ;
ALTER TABLE
    BIKETUBES ADD CONSTRAINT FK_TUBEMATERIALBIKETUBES FOREIGN KEY(TUBEID) REFERENCES TUBEMATERIAL(TUBEID) ON DELETE CASCADE ;  --

    --  Ref Constraints for Table COMPONENT
     --

ALTER TABLE
    COMPONENT ADD CONSTRAINT FK_REFERENCE FOREIGN KEY(CATEGORY) REFERENCES COMPONENTNAME(COMPONENTNAME) ON DELETE CASCADE ;
ALTER TABLE
    COMPONENT ADD CONSTRAINT FK_REFERENCE16 FOREIGN KEY(MANUFACTURERID) REFERENCES MANUFACTURER(MANUFACTURERID) ON DELETE CASCADE ;  --

    --  Ref Constraints for Table CUSTOMER
     --

ALTER TABLE
    CUSTOMER ADD CONSTRAINT FK_CITYCUSTOMER FOREIGN KEY(CITYID) REFERENCES CITY(CITYID) ;  --

    --  Ref Constraints for Table CUSTOMERTRANSACTION
     --

ALTER TABLE
    CUSTOMERTRANSACTION ADD CONSTRAINT FK_REFERENCE18 FOREIGN KEY(CUSTOMERID) REFERENCES CUSTOMER(CUSTOMERID) ON DELETE CASCADE ;  --

    --  Ref Constraints for Table EMPLOYEE
     --

ALTER TABLE
    EMPLOYEE ADD CONSTRAINT FK_CITYEMPLOYEE FOREIGN KEY(CITYID) REFERENCES CITY(CITYID) ;  --

    --  Ref Constraints for Table GROUPCOMPONENTS
     --

ALTER TABLE
    GROUPCOMPONENTS ADD CONSTRAINT FK_REFERENCE14 FOREIGN KEY(COMPONENTID) REFERENCES COMPONENT(COMPONENTID) ON DELETE CASCADE ;
ALTER TABLE
    GROUPCOMPONENTS ADD CONSTRAINT FK_REFERENCE15 FOREIGN KEY(GROUPID) REFERENCES GROUPO(COMPONENTGROUPID) ON DELETE CASCADE ;  --

    --  Ref Constraints for Table MANUFACTURER
     --

ALTER TABLE
    MANUFACTURER ADD CONSTRAINT FK_CITYMANUFACTURER FOREIGN KEY(CITYID) REFERENCES CITY(CITYID) ;  --

    --  Ref Constraints for Table MANUFACTURERTRANSACTION
     --

ALTER TABLE
    MANUFACTURERTRANSACTION ADD CONSTRAINT FK_MANUFTRANS FOREIGN KEY(MANUFACTURERID) REFERENCES MANUFACTURER(MANUFACTURERID) ON DELETE CASCADE ;  --

    --  Ref Constraints for Table MODELSIZE
     --

ALTER TABLE
    MODELSIZE ADD CONSTRAINT FK_MODELTYPE FOREIGN KEY(MODELTYPE) REFERENCES MODELTYPE(MODELTYPE) ON DELETE CASCADE ;  --

    --  Ref Constraints for Table PURCHASEITEM
     --

ALTER TABLE
    PURCHASEITEM ADD CONSTRAINT FK_REFERENCE20 FOREIGN KEY(PURCHASEID) REFERENCES PURCHASEORDER(PURCHASEID) ON DELETE CASCADE ;
ALTER TABLE
    PURCHASEITEM ADD CONSTRAINT FK_REFERENCE21 FOREIGN KEY(COMPONENTID) REFERENCES COMPONENT(COMPONENTID) ON DELETE CASCADE ;  --

    --  Ref Constraints for Table PURCHASEORDER
     --

ALTER TABLE
    PURCHASEORDER ADD CONSTRAINT FK_REFERENCE22 FOREIGN KEY(MANUFACTURERID) REFERENCES MANUFACTURER(MANUFACTURERID) ON DELETE CASCADE ;
ALTER TABLE
    PURCHASEORDER ADD CONSTRAINT FK_REFERENCE23 FOREIGN KEY(EMPLOYEEID) REFERENCES EMPLOYEE(EMPLOYEEID) ON DELETE CASCADE ;  --

    --  Ref Constraints for Table RETAILSTORE
     --

ALTER TABLE
    RETAILSTORE ADD CONSTRAINT FK_CITYRETAILSTORE FOREIGN KEY(CITYID) REFERENCES CITY(CITYID) ;
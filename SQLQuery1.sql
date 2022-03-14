create database ClinicManagement;
use ClinicManagement;

create table Patient( 
PatientNo int Identity(1,1) Primary Key,
PatientName Varchar(100) not null ,
PatientMobNo varchar(50) not null ,
 );

insert into Patient values('Harsh', 6264639296);
Delete from Patient where PatientName='Harsh';


create table Patient_MedInfo(

	
	PatientNO int  FOREIGN KEY REFERENCES Patient(PatientNo),
	PatientWeight float ,
	
	BloodPressure varchar(50),
	Cholestrol varchar(50),
	Sugar varchar(10),
	MedicineSubscribed varchar(1000),

	AppointmentDate Date,  /*yyyy-mm-dd*/
	NextAppointment Date,
	Amount int
);
Alter table Patient_MedInfo add MedInfoId int Identity(1,1) Primary Key;
drop table Patient_MedInfo;

select * from Patient_MedInfo;
select * from Patient;

insert into Patient_MedInfo(PatientNO ,BloodPressure ,Cholestrol ,Sugar ,MedicineSubscribed ,AppointmentDate  ) values(1,100,80,100,90,'Dolo','2022-03-02');
insert into Patient_MedInfo(PatientNO,PatientWeight ,BloodPressure ,Cholestrol ,Sugar ,MedicineSubscribed ,AppointmentDate, NextAppointment ,Amount ) values(1,100,80,100,90,'Dolo','2022-03-02','2022-03-03', 12901);

Delete from Patient_MedInfo where PatientNo =1;
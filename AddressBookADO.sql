use AddressBookForADO
select * from AddressBook

Insert into AddressBook values ('Aarvik','Kalburgi','XYZ Colony','Pune','MH','431001','9000000002','aarvik@gmail.com')
Insert into AddressBook values ('Sagar','Kalburgi','XYZ Colony','Pune','MH','411033','9000000003','sagar@gmail.com')
Insert into AddressBook values ('Disha','Badjate','ABC Colony','Abad','MH','431001','9000000004','disha@gmail.com')

update AddressBook set AddressBookName ='School',AddressBookType='Friend' where ID=5; 
update AddressBook set AddressBookName ='Relative',AddressBookType='Cousin' where ID=4; 
update AddressBook set AddressBookName ='Profession',AddressBookType='Colleague' where ID=2; 
update AddressBook set AddressBookName ='Self',AddressBookType='Self' where ID=1; 
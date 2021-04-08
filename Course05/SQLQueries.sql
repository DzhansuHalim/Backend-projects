--Select + From
Select *, ColumnName1 GiveNewName, ColumnName2 from TableName

--Select + From + Where (=, <=, =>, <>, or, and) 
Select* from TableName where ColumnName = '...' or ColumnName = '...'

--Select + From + Where (=, <=, =>, <>, or, and)  + Order by + ascending  
Select* from TableName where ColumnName = '...' order by ColumnName asc

--Select + From + Where (=, <=, =>, <>, or, and)  + Order by + descending  
Select* from TableName  where ColumnName = '...'  order by ColumnName desc

--Select + count + From + Where (=, <=, =>, <>, or, and) 
Select count(*) GiveNewName from TableName where ColumnName = '...'

--Select + count + From + Where (=, <=, =>, <>, or, and)  + Group by + having
Select ColumnName1, count(*) From TableName where ColumnName = '...' 
Group by ColumName1 having count(*) < Number


--Select + From + Inner Join, Left Join, Right Join + On
Select * 
From TableName1 inner join TableName2
On TableName1.ColumName = TableName2.ColumName

Select * 
From TableName1 left join TableName2
On TableName1.ColumName = TableName2.ColumName
where TableName2.ColumnName is null
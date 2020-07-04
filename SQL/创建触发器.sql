create trigger tri on SC after insert
as if exists(select COUNT(Cno) from SC
group by Sno
having COUNT(Cno) > 5)
rollback

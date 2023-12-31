select a.student_id, a.student_name, b.subject_name,  Count(c.subject_name) AS attended_exams 
from students a 
cross join subjects b 
left join examinations c 
on a.student_id = c.student_id 
and b.subject_name = c.subject_name 
group by a.student_id, b.subject_name
order by a.student_id, b.subject_name
SELECT a.FID,a.FName,a.ParentFID from b_sysfunction a
left join b_roleright b on a.FID=b.FID and b.RoleID = 1
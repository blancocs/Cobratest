Select Concat(CU.firstName, ' ', cu.LastName) as 'FullName', cu.Age, O.DateCreated, 
O.MethodOfPurchase, OD.ProductNumber, OD.ProductOrigin 
from customer CU
inner join Orders as O on CU.PersonId = O.PersonID
inner join OrdersDetails OD on o.OrderID = OD.OrderID
where OD.ProductID = 1112222333
order by o.DateCreated
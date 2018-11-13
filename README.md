### Subject: C# Programming Tutorial
### Author: Mr.Mao
-------------

Contents
--------

Homework1:
>program1:	控制台程序，计算两个数的积  
>program2:	Windows应用程序，计算两个数的积  


Homework2:
>program1:	计算输入数据的素数因子  
>program2:	求以整数组的最大值、最小值、平均值、所有元素的和  
>program3:	埃氏筛法求2~100内的素数  

Homework3:
>program1:  使用简单工厂模式创建洗个图形（三角形、圆形、正方形、长方形），然后计算每个图形的面积


Homework4:
>program1:使用事件机制，模拟实现闹钟的定时功能，可以设置闹钟，在闹钟时间到了以后，在控制台显示提示信息。
>program2:一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询）功能。
		在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
>>提示：包含Order（订单）、OrderDetails（订单明细），OrderService（订单服务）几个类，订单数据可以保存在OrderService中一个List中。
		（一个订单中包含多个订单明细）
		
Homework5:
>program1:对上次订单程序，使用LINQ语句
>>(1)实现按照商品名称、客户等字段查询订单的功能
>>(2)查询订单金额大于1万元的订单

>program2:Cayley树，添加一些控件，以方便用户修改角度、长度，添加两子树的位置系数，颜色、粗细、是否随机......

Homework6:
>program1:在OrderService中添加一个Export方法，可以将所有的订单序列化为XML文件；添加一个Import方法可以从XML文件中载入订单。  
>program1test:为OrderService类的各个Public方法，编写测试用例，使用合法和非法的输出数据进行测试。

Homework7:
>OrderServiceWinForm:为订单管理的程序添加一个WinForm的界面。通过这个界面，调用OrderService的各个方法，
        实现创建订单、删除订单、修改订单、查询订单等功能。
>>要求：
>>（1）WinForm的界面部分单独写一个项目，依赖于原来的项目。

>>（2）主窗口实现查询展示功能，以及放置各种功能按钮。新建/修改订单功能使用弹出窗口。

>>（3）尽量通过数据绑定来实现功能。 注：订单明细可以设置DataMember来绑定。

Homework8(直接在Homework7上进行修改):
>1、为订单添加数据验证功能，要求
  >>（1）订单号不能为空、不能重复、并且是”年月日+三位流水号”的形式。
  
  >>（2）客户的电话号码是正确的格式。
  
>2、将订单导出为HTML文件，在浏览器打开并显示。（备注：使用XSLT进行转换） 
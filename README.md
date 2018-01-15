# Book Management System 图书管理系统

本项目为图书馆图书管理系统，应用于图书馆等场景。

功能介绍及配置如下介绍。

## Function 功能

用户端：

- 通过学号等信息注册成为系统用户
- 根据条件检索相应图书，浏览图书详细信息
- 对书籍进行评论
- 进行图书借阅&预约
- 对图书进行归还&延期归还
- 修改个人信息

管理端：

- 查看系统基本信息（书籍数量，借阅率，用户数量）
- 检索用户，查看用户信息
- 对用户进行密码重置、信用重置
- 查阅书籍，维护评论
- 添加新的图书

## Getting Started 使用手册

- 项目运行平台：`windows 7/8/8.1/10` （`xp`及以下版本未测试）

- 项目开发平台：`Visual Studio 2015`

- 数据库：`Microsoft Server 2016`

- 客户端配置文件

  ```xml
  <?xml version="1.0" encoding="UTF-8"?>
  <ROOT>
    <serverconfig>
      <ipaddress>10.115.249.190</ipaddress>  <!--服务器地址-->
    </serverconfig>
  </ROOT>
  ```

- 服务器配置文件

  ```xml
  <?xml version="1.0" encoding="UTF-8"?>
  <ROOT>
    <sqlconfig>
      <sqlname>10.105.249.***,1433</sqlname>	<!--数据库地址-->
      <loginname>***</loginname>				<!--数据库用户名-->
      <loginpassword>******</loginpassword>	<!--数据库密码-->
      <initialcatalog>db_Library</initialcatalog>
    </sqlconfig>
  </ROOT>

  ```

  ​


## Tests 运行实例

![1](https://github.com/Kou-Akira/LIBRARY/blob/master/DescribeImag/1.png)

![2](https://github.com/Kou-Akira/LIBRARY/blob/master/DescribeImag/2.png)

![3](https://github.com/Kou-Akira/LIBRARY/blob/master/DescribeImag/3.png)

## Contributors 参与者

- **Sean Huang**  **黄晓宇** - *Front-end Build* - [Kou-Akira](https://github.com/Kou-Akira)


- **Peter Xiao** **肖智轩** - *Back-end Build* - [xzxxzx401](https://github.com/xzxxzx401)
- **Xingguo Jiang 姜兴国** - *Front-end & Test work* - [Augusto111](https://github.com/Augusto111)


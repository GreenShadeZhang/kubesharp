# kubesharp 路线图

基于.Net 技术栈，开发出前后端分离的web服务，主要功能为k8s集群的基础管理。

后期功能对标kubesphere，rancher，争做一个好用的企业级工具。

### 前期规划

+ 基础服务搭建，包含项目架构，初期的服务数量，技术选型。

+ 功能开发，最小化实现集群的管理，包含一些资源的管理和服务的简单运维。

+ 然后是SaaS化管理，增加相关的服务。

### 暂定组件

+ DDD模式开发 
  参考：
  [eShopOnContainers案例](https://github.com/ardalis/CleanArchitecture)
  [Clean框架](https://github.com/ardalis/CleanArchitecture)
+ 数据库：Mysql
+ ORM框架：EFCore + Dapper
+ 可能用到组件 MediaR、Rebus、SingalR

### 阶段目标

1. 完成基础框架搭建
2. 对接K8s的dotnetsdk的基础api
3. 数据库基础设施
4. MediaR、Rebus介入
5. 命名空间、Pods、Service页面的CRUD

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FrontServiceClientStub.cs" company="DNU">
//   DNU
// </copyright>
// <summary>
//   Defines the FontServiceClientStub type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Warehouse.Front.Service.Client.Stub
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Warehouse.DTO;
    using Warehouse.Front.Service.Client.Contract;

    /// <inheritdoc />
    /// <summary>
    /// The font service client stub.
    /// </summary>
    public class FrontServiceClientStub : IFrontServiceClient
    {
        /// <summary>
        /// The user registration list.
        /// </summary>
        private readonly List<UserLogin> userLoginList;

        /// <summary>
        /// The warehouse goodse list.
        /// </summary>
        private readonly List<WarehouseGoods> warehouseGoodseList;

        /// <summary>
        /// The provider list.
        /// </summary>
        private readonly List<ProviderDto> providerList;

        /// <summary>
        /// The goods category list.
        /// </summary>
        private readonly List<GoodsCategoryDto> goodsCategoryList;

        /// <summary>
        /// The goods class list.
        /// </summary>
        private readonly List<GoodsClassDto> goodsClassList;

        /// <summary>
        /// The goods list.
        /// </summary>
        private readonly List<GoodsDto> goodsList;

        /// <summary>
        /// Initializes a new instance of the <see cref="FrontServiceClientStub"/> class.
        /// </summary>
        public FrontServiceClientStub()
        {
            this.userLoginList = new List<UserLogin>
                                            {
                                                new UserLogin
                                                    {
                                                        Login = "victoria",
                                                        Password = "1111"
                                                    }
                                            };
            this.warehouseGoodseList = new List<WarehouseGoods>
                                           {
                                                /*new WarehouseGoods
                                                    {
                                                        GoodsId = 1,
                                                        Title = "Apples",
                                                        Provider = new ProviderDto
                                                                       {
                                                                           ProviderId = 1,
                                                                           Name = "Dnipro Provider",
                                                                           Address = "Dnipro",
                                                                           Phone = "1111111"
                                                                       },
                                                        GoodsCategory = new GoodsCategoryDto
                                                                            {
                                                                                GoodsCategoryId = 1,
                                                                                Title = "Food"
                                                                            },
                                                        GoodsClass = new GoodsClassDto
                                                                         {
                                                                             GoodsClassId = 1,
                                                                             Title = "First Class"
                                                                         },
                                                        Amount = 7,
                                                        UnitPrice = 10.0m,
                                                        DateTimeDelivery = DateTime.Now - TimeSpan.FromMinutes(10),
                                                        State = "Accrued"
                                                    },
                                               new WarehouseGoods
                                                   {
                                                       GoodsId = 2,
                                                       Title = "Lego",
                                                       Provider = new ProviderDto
                                                                      {
                                                                          ProviderId = 2,
                                                                          Name = "Kharkiv Provider",
                                                                          Address = "Kharkiv",
                                                                          Phone = "2222222"
                                                                      },
                                                       GoodsCategory = new GoodsCategoryDto
                                                                           {
                                                                               GoodsCategoryId = 2,
                                                                               Title = "Toys"
                                                                           },
                                                       GoodsClass = new GoodsClassDto
                                                                        {
                                                                            GoodsClassId = 2,
                                                                            Title = "Second Class"
                                                                        },
                                                       Amount = 22,
                                                       UnitPrice = 2.0m,
                                                       DateTimeDelivery = DateTime.Now - TimeSpan.FromMinutes(5),
                                                       State = "Accrued"
                                                   },
                                               new WarehouseGoods
                                                   {
                                                       GoodsId = 3,
                                                       Title = "Nike",
                                                       Provider = new ProviderDto
                                                                      {
                                                                          ProviderId = 3,
                                                                          Name = "Kyiv Provider",
                                                                          Address = "Kyiv",
                                                                          Phone = "3333333"
                                                                      },
                                                       GoodsCategory = new GoodsCategoryDto
                                                                           {
                                                                               GoodsCategoryId = 3,
                                                                               Title = "Clothes"
                                                                           },
                                                       GoodsClass = new GoodsClassDto
                                                                        {
                                                                            GoodsClassId = 3,
                                                                            Title = "Third Class"
                                                                        },
                                                       Amount = 10,
                                                       UnitPrice = 3.0m,
                                                       DateTimeDelivery = DateTime.Now,
                                                       State = "Accrued"
                                                   },
                                                        new WarehouseGoods
                                                   {
                                                       GoodsId = 3,
                                                       Title = "Goods Title",
                                                       Provider = new ProviderDto
                                                                      {
                                                                            ProviderId = 4,
                                                                            Name = "Provider",
                                                                            Address = "ProviderCity",
                                                                            Phone = "4444444"
                                                                      },
                                                       GoodsCategory = new GoodsCategoryDto
                                                                           {
                                                                               GoodsCategoryId = 4,
                                                                               Title = "Goods Category"
                                                                           },
                                                       GoodsClass = new GoodsClassDto
                                                                        {
                                                                            GoodsClassId = 4,
                                                                            Title = "Goods Class"
                                                                        },
                                                       Amount = 10,
                                                       UnitPrice = 3.0m,
                                                       DateTimeDelivery = DateTime.Now,
                                                       State = "Accrued"
                                                   }*/
                                            };
            this.providerList = new List<ProviderDto>
                                    {
                                        new ProviderDto
                                            {
                                                ProviderId = 1,
                                                Name = "Dnipro Provider",
                                                Address = "Dnipro",
                                                Phone = "1111111"
                                            },
                                        new ProviderDto
                                            {
                                                ProviderId = 2,
                                                Name = "Kharkiv Provider",
                                                Address = "Kharkiv",
                                                Phone = "2222222"
                                            },
                                        new ProviderDto
                                            {
                                                ProviderId = 3,
                                                Name = "Kyiv Provider",
                                                Address = "Kyiv",
                                                Phone = "3333333"
                                            },
                                        new ProviderDto
                                            {
                                                ProviderId = 4,
                                                Name = "Provider",
                                                Address = "ProviderCity",
                                                Phone = "4444444"
                                            }
                                    };
            this.goodsCategoryList = new List<GoodsCategoryDto>
                                         {
                                             new GoodsCategoryDto
                                                 {
                                                     GoodsCategoryId = 1,
                                                     Title = "Food"
                                                 },
                                             new GoodsCategoryDto
                                                 {
                                                     GoodsCategoryId = 2,
                                                     Title = "Toys"
                                                 },
                                             new GoodsCategoryDto
                                                 {
                                                     GoodsCategoryId = 3,
                                                     Title = "Clothes"
                                                 },
                                             new GoodsCategoryDto
                                                 {
                                                     GoodsCategoryId = 4,
                                                     Title = "Goods Category"
                                                 }
                                         };
            this.goodsClassList = new List<GoodsClassDto>
                                      {
                                          new GoodsClassDto
                                              {
                                                  GoodsClassId = 1,
                                                  Title = "First Class"
                                              },
                                          new GoodsClassDto
                                              {
                                                  GoodsClassId = 2,
                                                  Title = "Second Class"
                                              },
                                          new GoodsClassDto
                                              {
                                                  GoodsClassId = 3,
                                                  Title = "Third Class"
                                              },
                                          new GoodsClassDto
                                              {
                                                  GoodsClassId = 4,
                                                  Title = "Goods Class"
                                              }
                                      };
            this.goodsList = new List<GoodsDto>
                                 {
                                     new GoodsDto
                                         {
                                             GoodsCategory = this.goodsCategoryList[0],
                                             GoodsClass = this.goodsClassList[0],
                                             GoodsId = 1,
                                             Price = 1.0m,
                                             Provider = this.providerList[0],
                                             Title = "Apples"
                                         },
                                     new GoodsDto
                                         {
                                             GoodsCategory = this.goodsCategoryList[1],
                                             GoodsClass = this.goodsClassList[1],
                                             GoodsId = 2,
                                             Price = 2.0m,
                                             Provider = this.providerList[1],
                                             Title = "Lego"
                                         },
                                     new GoodsDto
                                         {
                                             GoodsCategory = this.goodsCategoryList[2],
                                             GoodsClass = this.goodsClassList[2],
                                             GoodsId = 3,
                                             Price = 3.0m,
                                             Provider = this.providerList[2],
                                             Title = "Nike"
                                         },
                                     new GoodsDto
                                         {
                                             GoodsCategory = this.goodsCategoryList[3],
                                             GoodsClass = this.goodsClassList[3],
                                             GoodsId = 5,
                                             Price = 10.0m,
                                             Provider = this.providerList[3],
                                             Title = "Goods Title"
                                         }
                                 };
        }

        /// <inheritdoc />
        /// <summary>
        /// The system enter.
        /// </summary>
        /// <param name="userLogin">
        /// The user login.
        /// </param>
        /// <returns>
        /// The <see cref="T:System.Boolean" />.
        /// </returns>
        public int SystemEnter(UserLogin userLogin)
        {
            return this.userLoginList.Contains(userLogin) ? -1 : 1;
        }

        /// <inheritdoc />
        /// <summary>
        /// The registration.
        /// </summary>
        /// <param name="userRegistration">
        /// The user registration.
        /// </param>
        public void Registration(UserRegistration userRegistration)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// The get all warehouse goods.
        /// </summary>
        /// <returns>
        /// The <see cref="T:System.Collections.Generic.IEnumerable`1" />.
        /// </returns>
        public IEnumerable<WarehouseGoods> GetAllWarehouseGoods() => this.warehouseGoodseList;

        /// <inheritdoc />
        /// <summary>
        /// The get all provider.
        /// </summary>
        /// <returns>
        /// The <see cref="T:System.Collections.Generic.IEnumerable`1" />.
        /// </returns>
        public IEnumerable<ProviderDto> GetAllProvider() => this.providerList;

        /// <inheritdoc />
        /// <summary>
        /// The get goods by provider id.
        /// </summary>
        /// <param name="providerId">
        /// The provider id.
        /// </param>
        /// <returns>
        /// The <see cref="T:System.Collections.Generic.IEnumerable`1" />.
        /// </returns>
        public IEnumerable<WarehouseGoods> GetWarehouseGoodsByProviderId(int providerId) => this.warehouseGoodseList
                            .Where(x => x.Provider.ProviderId == providerId);

        /// <inheritdoc />
        /// <summary>
        /// The get all goods class.
        /// </summary>
        /// <returns>
        /// The <see cref="T:System.Collections.Generic.IEnumerable`1" />.
        /// </returns>
        public IEnumerable<GoodsClassDto> GetAllGoodsClass()
        {
            return this.goodsClassList;
        }

        /// <inheritdoc />
        /// <summary>
        /// The get all goods category.
        /// </summary>
        /// <returns>
        /// The <see cref="T:System.Collections.Generic.IEnumerable`1" />.
        /// </returns>
        public IEnumerable<GoodsCategoryDto> GetAllGoodsCategory()
        {
            return this.goodsCategoryList;
        }

        /// <inheritdoc />
        /// <summary>
        /// The get goods by provider id.
        /// </summary>
        /// <param name="providerId">
        /// The provider id.
        /// </param>
        /// <returns>
        /// The <see cref="T:System.Collections.Generic.IEnumerable`1" />.
        /// </returns>
        public IEnumerable<GoodsDto> GetGoodsByProviderId(int providerId)
        {
            return this.goodsList.Where(x => x.Provider.ProviderId == providerId);
        }

        /// <inheritdoc />
        /// <summary>
        /// The get goods by class id.
        /// </summary>
        /// <param name="classId">
        /// The class id.
        /// </param>
        /// <returns>
        /// The <see cref="T:System.Collections.Generic.IEnumerable`1" />.
        /// </returns>
        public IEnumerable<GoodsDto> GetGoodsByClassId(int classId)
        {
            return this.goodsList.Where(x => x.GoodsClass.GoodsClassId == classId);
        }

        /// <inheritdoc />
        /// <summary>
        /// The get goods by category id.
        /// </summary>
        /// <param name="categoryId">
        /// The category id.
        /// </param>
        /// <returns>
        /// The <see cref="T:System.Collections.Generic.IEnumerable`1" />.
        /// </returns>
        public IEnumerable<GoodsDto> GetGoodsByCategoryId(int categoryId)
        {
            return this.goodsList.Where(x => x.GoodsCategory.GoodsCategoryId == categoryId);
        }

        /// <inheritdoc />
        /// <summary>
        /// The add warehouse goods.
        /// </summary>
        /// <param name="warehouseGoods">
        /// The warehouse goods.
        /// </param>
        public void AddWarehouseGoods(IEnumerable<WarehouseGoods> warehouseGoods)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// The add goods of provider.
        /// </summary>
        /// <param name="goods">
        /// The goods.
        /// </param>
        public void AddGoodsOfProvider(GoodsDto goods)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// The get all goods.
        /// </summary>
        /// <returns>
        /// The <see cref="T:System.Collections.Generic.IEnumerable`1" />.
        /// </returns>
        public IEnumerable<GoodsDto> GetAllGoods()
        {
            return this.goodsList;
        }

        /// <inheritdoc />
        /// <summary>
        /// The update goods.
        /// </summary>
        /// <param name="goods">
        /// The goods.
        /// </param>
        public void UpdateGoods(GoodsDto goods)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// The update provider.
        /// </summary>
        /// <param name="provider">
        /// The provider.
        /// </param>
        public void UpdateProvider(ProviderDto provider)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// The get goods by class and period.
        /// </summary>
        /// <param name="classId">
        /// The class id.
        /// </param>
        /// <param name="startDate">
        /// The start date.
        /// </param>
        /// <param name="endDate">
        /// The end date.
        /// </param>
        /// <returns>
        /// The <see cref="T:System.Collections.Generic.IEnumerable`1" />.
        /// </returns>
        public IEnumerable<WarehouseGoods> GetGoodsByClassAndPeriod(int classId, DateTime startDate, DateTime endDate)
        {
            return this.warehouseGoodseList.Where(
                x => x.GoodsClass.GoodsClassId == classId && x.DateTimeDelivery >= startDate && x.DateTimeDelivery <= endDate);
        }

        /// <inheritdoc />
        /// <summary>
        /// The get report by period and type.
        /// </summary>
        /// <param name="startDate">
        /// The start date.
        /// </param>
        /// <param name="endDate">
        /// The end date.
        /// </param>
        /// <returns>
        /// The <see cref="T:System.Collections.Generic.IEnumerable`1" />.
        /// </returns>
        /// <exception cref="T:System.NotImplementedException">
        /// </exception>
        public IEnumerable<ReportDto> GetReportByPeriodAndType(DateTime startDate, DateTime endDate)
        {
            return new List<ReportDto>
                       {
                           new ReportDto
                               {
                                   AmountReturnedGoods = 2,
                                   AmountSalesGoods = 5,
                                   AmountAccruedGoods = 7,
                                   GoodsClass = new GoodsClassDto(1, "First Class"),
                                   SalesRenuve = 200m,
                                   SumFromSales = 1000m
                               },
                           new ReportDto
                               {
                                   AmountReturnedGoods = 2,
                                   AmountSalesGoods = 20,
                                   AmountAccruedGoods = 22,
                                   GoodsClass = new GoodsClassDto(2, "Second Class"),
                                   SalesRenuve = 100m,
                                   SumFromSales = 20000m
                               }
                       };
        }

        /// <inheritdoc />
        /// <summary>
        /// The sale.
        /// </summary>
        /// <param name="warehouseGoods">
        /// The warehouse goods.
        /// </param>
        /// <param name="amount">
        /// The amount.
        /// </param>
        public void Sale(WarehouseGoods warehouseGoods, int amount)
        {
        }
    }
}
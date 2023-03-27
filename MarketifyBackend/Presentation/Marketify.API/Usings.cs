﻿global using FluentValidation;
global using FluentValidation.AspNetCore;
global using Marketify.API.Configurations.ColumnWriters;
global using Marketify.API.Extensions;
global using Marketify.Application;
global using Marketify.Application.Features.Commands.Baskets.AddItemToBasket;
global using Marketify.Application.Features.Commands.Baskets.RemoveBasketItem;
global using Marketify.Application.Features.Commands.Baskets.UpdateQuantity;
global using Marketify.Application.Features.Commands.Orders.CreateOrder;
global using Marketify.Application.Features.Commands.ProductImageFiles.RemoveProductImage;
global using Marketify.Application.Features.Commands.ProductImageFiles.UpdateProductImage;
global using Marketify.Application.Features.Commands.Products.CreateProduct;
global using Marketify.Application.Features.Commands.Products.RemoveProduct;
global using Marketify.Application.Features.Commands.Products.UpdateProduct;
global using Marketify.Application.Features.Commands.Users.CreateUser;
global using Marketify.Application.Features.Commands.Users.FacebookLogin;
global using Marketify.Application.Features.Commands.Users.GoogleLogin;
global using Marketify.Application.Features.Commands.Users.LoginUser;
global using Marketify.Application.Features.Commands.Users.RefreshTokenLogin;
global using Marketify.Application.Features.Queries.Baskets.GetBasketItems;
global using Marketify.Application.Features.Queries.Orders;
global using Marketify.Application.Features.Queries.ProductImageFiles.GetProductImages;
global using Marketify.Application.Features.Queries.Products.GetAllProduct;
global using Marketify.Application.Features.Queries.Products.GetByIdProduct;
global using Marketify.Application.Validators.Products;
global using Marketify.Infrastructure;
global using Marketify.Infrastructure.Filters;
global using Marketify.Infrastructure.Services.Storage.Azure;
global using Marketify.Persistence;
global using Marketify.SignalR;
global using MediatR;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Diagnostics;
global using Microsoft.AspNetCore.HttpLogging;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.IdentityModel.Tokens;
global using NpgsqlTypes;
global using Serilog;
global using Serilog.Context;
global using Serilog.Core;
global using Serilog.Events;
global using Serilog.Sinks.PostgreSQL;
global using System.Net;
global using System.Net.Mime;
global using System.Security.Claims;
global using System.Text;
global using System.Text.Json;
﻿global using FluentValidation;
global using Marketify.Application.Abstractions.Hubs;
global using Marketify.Application.Abstractions.Services;
global using Marketify.Application.Abstractions.Services.Authentications;
global using Marketify.Application.Abstractions.Storage;
global using Marketify.Application.DTOs;
global using Marketify.Application.DTOs.Configuration;
global using Marketify.Application.DTOs.Orders;
global using Marketify.Application.DTOs.User;
global using Marketify.Application.Enums;
global using Marketify.Application.Exceptions;
global using Marketify.Application.Repositories.ProductImageFiles;
global using Marketify.Application.Repositories.Products;
global using Marketify.Application.ViewModels;
global using Marketify.Application.ViewModels.Baskets;
global using Marketify.Domain;
global using Marketify.Domain.Entities;
global using Marketify.Domain.Entities.Common;
global using Marketify.Domain.Entities.Identity;
global using MediatR;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.WebUtilities;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using System.Linq.Expressions;
global using System.Text;
global using System.Text.Json.Serialization;
global using Endpoint = Marketify.Domain.Entities.Endpoint;
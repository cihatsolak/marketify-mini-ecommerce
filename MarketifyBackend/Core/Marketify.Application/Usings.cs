﻿global using FluentValidation;
global using Google.Apis.Auth;
global using Marketify.Application.Abstractions.Storage;
global using Marketify.Application.Abstractions.Tokens;
global using Marketify.Application.DTOs;
global using Marketify.Application.Exceptions;
global using Marketify.Application.Repositories.ProductImageFiles;
global using Marketify.Application.Repositories.Products;
global using Marketify.Application.ViewModels;
global using Marketify.Domain;
global using Marketify.Domain.Entities;
global using Marketify.Domain.Entities.Common;
global using Marketify.Domain.Entities.Identity;
global using MediatR;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using System.Linq.Expressions;
global using System.Text;

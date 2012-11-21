﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Samba.Domain.Models.Accounts;
using Samba.Domain.Models.Menus;
using Samba.Domain.Models.Resources;
using Samba.Domain.Models.Settings;
using Samba.Domain.Models.Tickets;
using Samba.Presentation.Services.Common;

namespace Samba.Presentation.Services
{
    public interface IPresentationCacheService
    {
        void ResetOrderTagCache();
        void ResetTicketTagCache();

        MenuItem GetMenuItem(Func<MenuItem, bool> expression);
        MenuItemPortion GetMenuItemPortion(int menuItemId, string portionName);
        ProductTimer GetProductTimer(int menuItemId);
        IEnumerable<OrderTagGroup> GetOrderTagGroups(params int[] menuItemIds);
        IEnumerable<OrderStateGroup> GetOrderStateGroups(params int[] menuItemIds);
        IEnumerable<MenuItemPortion> GetMenuItemPortions(int menuItemId);
        TicketTagGroup GetTicketTagGroupById(int id);
        IEnumerable<Resource> GetResourcesByTemplateId(int templateId);
        IEnumerable<ResourceType> GetResourceTypes();
        ResourceType GetResourceTypeById(int resourceTypeId);
        int GetResourceTypeIdByEntityName(string entityName);
        Account GetAccountById(int accountId);
        Resource GetResourceById(int resourceId);
        IEnumerable<AccountTransactionDocumentType> GetAccountTransactionDocumentTypes(int accountTypeId);
        IEnumerable<AccountTransactionDocumentType> GetBatchDocumentTypes(IEnumerable<string> accountTypeNamesList);
        ResourceState GetResourceStateById(int resourceStateId);
        ResourceState GetResourceStateByName(string stateName);
        IEnumerable<ResourceState> GetResourceStates();
        PrintJob GetPrintJobByName(string name);
        IEnumerable<PaymentType> GetUnderTicketPaymentTypes();
        IEnumerable<PaymentType> GetPaymentScreenPaymentTypes();
        IEnumerable<ChangePaymentType> GetChangePaymentTypes();
        IEnumerable<TicketTagGroup> GetTicketTagGroups();
        IEnumerable<AutomationCommandData> GetAutomationCommands();
        IEnumerable<CalculationSelector> GetCalculationSelectors();
        AccountType GetAccountTypeById(int accountTypeId);
        IEnumerable<AccountType> GetAccountTypes();
        IEnumerable<AccountType> GetAccountTypesByName(IEnumerable<string> accountTypeNames);
        ChangePaymentType GetChangePaymentTypeById(int id);
        
        IEnumerable<ResourceScreen> GetResourceScreens();
        IEnumerable<ResourceScreen> GetTicketResourceScreens();
        TicketType GetTicketTypeById(int ticketTypeId);
        IEnumerable<TicketType> GetTicketTypes();
        int GetTaskTypeIdByName(string taskTypeName);
        IEnumerable<string> GetTaskTypeNames();
    }
}
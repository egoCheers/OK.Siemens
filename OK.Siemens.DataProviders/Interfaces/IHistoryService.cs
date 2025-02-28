﻿using OK.Siemens.Models;

namespace OK.Siemens.DataProviders.Interfaces;

public interface IHistoryService
{
    /// <summary>
    /// Add tags category to repository
    /// </summary>
    /// <param name="categoryName"></param>
    /// <returns></returns>
    Task<(bool error, string message)> AddCategoryAsync(string categoryName);

    /// <summary>
    /// Return list of all plc tags
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<PlcTag>> GetTagsAsync();
}
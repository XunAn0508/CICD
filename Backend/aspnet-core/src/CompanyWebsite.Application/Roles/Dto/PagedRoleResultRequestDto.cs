﻿using Abp.Application.Services.Dto;

namespace CompanyWebsite.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}


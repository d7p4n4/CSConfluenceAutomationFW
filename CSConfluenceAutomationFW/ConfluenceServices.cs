using Modul.Final.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConfluenceAutomationFW
{
    class ConfluenceServices
    {
        public AddNewPageResponse AddNewPage(AddNewPageRequest request)
        {
            AddNewPageResponse response = new AddNewPageResponse();

            try
            {
                response.AddNewPageResult =
                    new ConfluenceAPIMetodusok().AddConfluencePage(
                        request.PageTitle
                        , request.SpaceKey
                        , request.ParentPageTitle
                        , request.Content
                        , request.URL
                        , request.Username
                        , request.Password
                        , request.IdLength
                        );
                response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.SUCCESS };
            }
            catch (Exception exception)
            {
                response.Result = (new Ac4yProcessResult() { Code = Ac4yProcessResult.FAIL, Message = exception.Message, Description = exception.StackTrace });
            }
            return response;
        }//AddNewPage

        public async Task<UploadAttachmentResponse> UploadAttachment(UploadAttachmentRequest request)
        {
            UploadAttachmentResponse response = new UploadAttachmentResponse();

            try
            {
                response.UploadAttachmentResult = await
                    new ConfluenceAPIMetodusok().UploadAttachment(
                        request.Username
                        , request.Password
                        , request.SpaceKey
                        , request.URL
                        , request.PageTitle
                        , request.ImageFileBase64String
                        , request.FileName
                        , request.IdLength
                        );
                response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.SUCCESS };
            }
            catch (Exception exception)
            {
                response.Result = (new Ac4yProcessResult() { Code = Ac4yProcessResult.FAIL, Message = exception.Message, Description = exception.StackTrace });
            }
            return response;
        }//AddNewPage


    }
}

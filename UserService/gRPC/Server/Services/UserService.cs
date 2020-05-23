using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using UserService.gRPC.Server.Protos;
using UserService.App.Controllers;
using Microsoft.AspNetCore.Http.Headers;
using UserService.App.CustomExceptions;

namespace UserService.gRPC.Server
{
    public class UserServiceImplementation : User.UserBase
    {
        public override async Task<GrpcStatusResponse> CreateUser(GrpcCreateUserRequest request, ServerCallContext call)
        {
            try
            {
                return await Controller.CreateUser(request);
            }
            catch (CustomException customException) 
            {
                throw HandleCustomException(customException);
            }
            catch (Exception e)
            {
                throw HandleError(e, call);
            }
            
        }

        public override async Task<GrpcStatusResponse> SignIn(GrpcSignInRequest request, ServerCallContext call)
        {
            try
            {
                return await Controller.SignIn(request);
            }
            catch (CustomException customException)
            {
                throw HandleCustomException(customException);
            }
            catch (Exception e)
            {
                throw HandleError(e, call);
            }
        }

        public override async Task<GrpcStatusResponse> UpdateUserData(GrpcUserUpdateRequest request, ServerCallContext call)
        {
            try
            {
                return await Controller.UpdateUserData(request);
            }
            catch (CustomException customException)
            {
                throw HandleCustomException(customException);
            }
            catch (Exception e)
            {
                throw HandleError(e, call);
            }
        }

        public override async Task<GrpcBooleanResponse> ValidateUsernameBool(GrpcValidateUsernameRequest request, ServerCallContext call)
        {
            try
            {
                return await Controller.ValidateUsernameBool(request);
            }
            catch(CustomException customException)
            {
                throw HandleCustomException(customException);
            }
            catch (Exception e)
            {
                throw HandleError(e, call);
            }
        }

        //----------------------------------------------------------------
        // Exception Handling --------------------------------------------
        public RpcException HandleCustomException (CustomException exception)
        {
            if(exception.Type == "InvalidInputData")
            {
                return new RpcException(new Status(StatusCode.InvalidArgument, exception.Message));
            }
            else
            {
                return new RpcException(new Status(StatusCode.Unknown, "Erro interno desconhecido."));
            }
        }

        public RpcException HandleError(Exception error, ServerCallContext call)
        {
            Console.WriteLine(error);
            return new RpcException(new Status(StatusCode.Internal, error.Message));
        }
    }
}

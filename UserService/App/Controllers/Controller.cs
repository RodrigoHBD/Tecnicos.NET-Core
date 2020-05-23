using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.gRPC.Server.Protos;
using UserService.App.TypeAdapters;
using UserService.App.UseCases;
using UserService.App.Presenters;
using UserService.App.TypeAdapters.UserUpdateRequest;

namespace UserService.App.Controllers
{
    public class Controller
    {
        public static async Task<GrpcStatusResponse> CreateUser(GrpcCreateUserRequest request)
        {
			try
			{
				var requestModel = CreateUserRequestAdapter.Adapt(request);
				await UseCaseController.CreateUser(requestModel);
				return Presenter.OkStatusResponse();
			}
			catch (Exception e)
			{
				throw e;
			}
        }

		public static async Task<GrpcStatusResponse> SignIn(GrpcSignInRequest request)
		{
			try
			{
				var requestModel = SignInRequestAdapter.Adapt(request);
				await UseCaseController.SignIn(requestModel);
				return Presenter.OkStatusResponse();
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public static async Task<GrpcStatusResponse> UpdateUserData(GrpcUserUpdateRequest grpcRequest)
		{
			try
			{
				var request = UserUpdateRequestAdapter.Adapt(grpcRequest);
				await UseCaseController.UpdateUserData(request);
				return Presenter.OkStatusResponse();
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public static async Task<GrpcBooleanResponse> ValidateUsernameBool(GrpcValidateUsernameRequest grpcRequest)
		{
			try
			{
				var user = ValidateUserBoolRequestAdapter.Adapt(grpcRequest);
				var isValid = await UseCaseController.ValidateUsernameBoolean(user);
				return Presenter.BooleanResponse(isValid);
			}
			catch (Exception e)
			{
				throw e;
			}
		}
	}
}

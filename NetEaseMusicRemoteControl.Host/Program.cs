using NetEaseMusicRemoteControl.Application.Music;
using NetEaseMusicRemoteControl.Application.Music.ShortcutKey;
using NetEaseMusicRemoteControl.Domain.MusicPlayer.Services.Interfaces;
using NetEaseMusicRemoteControl.Infrastructure.Services.KeyboardSimulator.Implement;
using NetEaseMusicRemoteControl.Infrastructure.Services.KeyboardSimulator.Interfaces;
using NetEaseMusicRemoteControl.Infrastructure.Services.MusicInfo.Implement;
using NetEaseMusicRemoteControl.Infrastructure.Services.MusicInfo.Interface;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddSingleton<IKeyboardSimulator, KeyboardSimulator>();
builder.Services.AddSingleton<IPlayerControlService, PlayerControlService>();
builder.Services.AddSingleton<IMusicService, MusicService>();
builder.Services.AddSingleton<IMusicInfo, MusicInfo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();

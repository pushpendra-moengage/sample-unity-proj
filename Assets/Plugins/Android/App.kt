package com.unity3d.player

import android.app.Application
import com.moengage.core.*
import com.moengage.unity.wrapper.MoEInitializer
import com.moengage.core.MoEngage 
import com.moengage.core.DataCenter
import com.moengage.core.LogLevel
import com.moengage.core.config.*
// import com.moengage.sampleapp.aar.R
import com.myunity.R



class App : Application() {

    val APP_ID = "8SIW681S80Z08KSHQFSTIZ8T"
    val NOT_INSTALLED = -1

    override fun onCreate() {
        super.onCreate()
    
        val moEngage = MoEngage.Builder(this, APP_ID, DataCenter.DATA_CENTER_1)
        moEngage.configureLogs(LogConfig(LogLevel.VERBOSE, true))
        moEngage.configureNotificationMetaData(NotificationConfig(R.drawable.insta, R.drawable.insta, -1, true, true, true))

        // MoEInitializer.initialize(getApplicationContext(), moEngage)
        MoEInitializer.initialiseDefaultInstance(applicationContext, moEngage)

        
    }
}